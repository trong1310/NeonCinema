// wwwroot/js/QuaggaScanner.js

let quaggaInitialized = false;

/**
 * Hàm bắt đầu Quagga
 * @param {any} dotNetRef Tham chiếu đến Blazor .NET object
 */
function startQuaggaScan(dotNetRef) {
    if (quaggaInitialized) {
        console.warn("Quagga đã được khởi tạo, bỏ qua!");
        return;
    }

    Quagga.init({
        inputStream: {
            type: "LiveStream",
            target: document.querySelector('#quagga-video'), // div hiển thị camera
            constraints: {
                facingMode: "environment", // Ưu tiên camera sau
                width: { ideal: 1920 },    // Tăng độ phân giải
                height: { ideal: 1080 }
            }
        },
        locator: {
            patchSize: "large", // "large" hoặc "xlarge" để tăng độ chính xác
            halfSample: false
            // Có thể bật "debug" nếu cần xem hình ảnh xử lý
        },
        decoder: {
            // Hỗ trợ nhiều loại mã vạch
            readers: [
                "code_128_reader",
                "ean_reader",
                "code_39_reader",
                "upc_reader"
            ]
        },
        locate: true,          // Tìm vị trí mã vạch tự động
        numOfWorkers: 4,       // Số worker (tùy theo CPU)
        frequency: 15          // Tần số quét
    }, function (err) {
        if (err) {
            console.error("Quagga init error:", err);
            alert("Không thể khởi tạo Quagga: " + err);
            return;
        }
        Quagga.start();
        quaggaInitialized = true;
        console.log("Quagga đã bắt đầu quét...");
    });

    // Các biến kiểm soát
    let lastCode = null;
    let confidenceThreshold = 0.8; // Ngưỡng độ tin cậy

    // Xử lý mỗi lần quét
    Quagga.onDetected(function (result) {
        const code = result.codeResult.code;

        // Tính toán lỗi trung bình (càng nhỏ càng tốt)
        let avgErrors = result.codeResult.decodedCodes
            .filter(x => x.error !== undefined)
            .map(x => x.error)
            .reduce((a, b) => a + b, 0) / result.codeResult.decodedCodes.length;

        // Độ tin cậy = 1 - avgErrors
        let confidence = 1 - avgErrors;
        console.log(`Mã quét được: ${code}, Độ tin cậy: ${confidence.toFixed(2)}`);

        if (confidence < confidenceThreshold) {
            console.warn("Độ tin cậy quá thấp, bỏ qua mã:", code);
            return;
        }

        // Tránh quét trùng liên tiếp
        if (code === lastCode) {
            console.log("Mã trùng, bỏ qua:", code);
            return;
        }
        lastCode = code;

        // Nếu BillCode yêu cầu >= 8 ký tự số
        if (code.length < 8 || !/^\d+$/.test(code)) {
            console.warn("Mã không hợp lệ (quá ngắn hoặc có ký tự không phải số):", code);
            return;
        }

        // Dừng Quagga
        Quagga.stop();
        quaggaInitialized = false;

        // Gửi dữ liệu về Blazor
        dotNetRef.invokeMethodAsync("OnQuaggaScanned", code);
    });
}

/**
 * Hàm dừng Quagga, giải phóng camera
 */
function stopQuagga() {
    if (quaggaInitialized) {
        Quagga.stop();
        quaggaInitialized = false;
        console.log("Quagga đã được dừng.");
    }
}

/**
 * Hàm tải file từ bytes[] (phục vụ in/tải PDF)
 * @param {string} fileName Tên file
 * @param {any} bytes Mảng byte
 * @param {string} mimeType Kiểu MIME
 */
function downloadFile(fileName, bytes, mimeType) {
    const blob = new Blob([new Uint8Array(bytes)], { type: mimeType });
    const link = document.createElement('a');
    link.href = URL.createObjectURL(blob);
    link.download = fileName;
    link.click();
    URL.revokeObjectURL(link.href); // Dọn dẹp URL
}
