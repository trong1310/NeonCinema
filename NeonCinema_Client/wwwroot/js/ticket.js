function htmlToImageOrPDF(elementId) {
    const element = document.getElementById(elementId);
    if (!element) {
        console.error("Không tìm thấy phần tử để tạo ảnh hoặc PDF.");
        return;
    }

    html2canvas(element).then(canvas => {
        const imgData = canvas.toDataURL('image/png');
        const pdf = new jspdf.jsPDF(); // Đảm bảo sử dụng jspdf chính xác
        pdf.addImage(imgData, 'PNG', 10, 10, 190, 0);
        pdf.save("ticket.pdf");
    }).catch(error => {
        console.error("Lỗi khi tạo PDF: ", error);
    });
}
