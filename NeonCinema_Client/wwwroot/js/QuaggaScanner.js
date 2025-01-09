// wwwroot/js/QuaggaScanner.js

let quaggaInitialized = false;

function startQuaggaScan(dotNetRef) {
    if (quaggaInitialized) {
        console.warn("Quagga đã được khởi tạo.");
        return;
    }

    Quagga.init({
        inputStream: {
            type: "LiveStream",
            target: document.querySelector('#quagga-video'),
            constraints: {
                facingMode: "environment", // Sử dụng camera sau
                width: { ideal: 1920 }, // Tăng độ phân giải để cải thiện độ chính xác
                height: { ideal: 1080 }
            }
        },
        locator: {
            patchSize: "large", // Kích thước lớn hơn để cải thiện độ chính xác
            halfSample: false, // Đảm bảo quét ảnh gốc
            debug: {
                showCanvas: true, // Hiển thị ảnh xử lý để kiểm tra
                showPatches: true,
                showFoundPatches: true,
                showSkeleton: true,
                showLabels: true,
                showPatchLabels: true,
                showRemainingPatchLabels: true,
                boxFromPatches: {
                    showTransformed: true,
                    showTransformedBox: true,
                    showBB: true
                }
            }
        },
        decoder: {
            readers: [
                "code_128_reader",
                "ean_reader",
                "code_39_reader",
                "upc_reader" // Thêm hỗ trợ cho mã UPC
            ]
        },
        locate: true, // Kích hoạt tìm kiếm mã vạch tự động
        numOfWorkers: navigator.hardwareConcurrency || 4, // Sử dụng tối đa số worker của CPU
        frequency: 15 // Tần số quét cao hơn để tăng độ nhạy
    }, function (err) {
        if (err) {
            console.error("Quagga init error:", err);
            alert("Không thể khởi tạo Quagga: " + err);
            return;
        }
        Quagga.start();
        quaggaInitialized = true;
        console.log("Quagga đã được khởi tạo và bắt đầu quét.");
    });

    // Xử lý sự kiện quét thành công
    let lastCode = null;
    let confidenceThreshold = 0.85; // Ngưỡng độ tin cậy

    Quagga.onDetected(function (result) {
        const code = result.codeResult.code;
        const confidence = result.codeResult.decodedCodes.reduce((sum, code) => sum + (code.error || 0), 0) / result.codeResult.decodedCodes.length;

        console.log(`Quét được mã: ${code}, Độ tin cậy: ${1 - confidence}`);

        if ((1 - confidence) < confidenceThreshold) {
            console.warn("Độ tin cậy thấp, bỏ qua mã:", code);
            return;
        }

        if (code === lastCode) {
            console.log("Mã trùng lặp, bỏ qua:", code);
            return;
        }

        if (code.length < 8 || !/^\d+$/.test(code)) {
            console.warn("Mã không hợp lệ:", code);
            return;
        }

        lastCode = code;
        console.log("Đã quét được mã hợp lệ:", code);

        // Dừng Quagga và gửi dữ liệu đến Blazor
        Quagga.stop();
        quaggaInitialized = false;
        dotNetRef.invokeMethodAsync("OnQuaggaScanned", code);
    });
}

function stopQuagga() {
    if (quaggaInitialized) {
        Quagga.stop();
        quaggaInitialized = false;
        console.log("Quagga đã được dừng.");
    }
}

function downloadFile(fileName, bytes, mimeType) {
    const blob = new Blob([new Uint8Array(bytes)], { type: mimeType });
    const link = document.createElement('a');
    link.href = URL.createObjectURL(blob);
    link.download = fileName;
    link.click();
    URL.revokeObjectURL(link.href); // Dọn dẹp URL
}

// Tính toán độ trung bình của mã để tăng độ tin cậy
function calculateConfidence(decodedCodes) {
    const confidenceScores = decodedCodes.map(code => 1 - (code.error || 0));
    return confidenceScores.reduce((sum, score) => sum + score, 0) / confidenceScores.length;
}
