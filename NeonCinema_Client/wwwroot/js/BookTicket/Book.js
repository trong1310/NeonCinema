function thaydoitongtien(amount) {
    const qrcode = document.getElementById("qrcode");
    const accountName = "NGUYEN VAN TRONG";
    qrcode.src = `https://api.vietqr.io/image/970418-1160087273-TDqOAw1.jpg?accountName=${accountName}&amount=${amount}&addInfo=Thanh%20toan%20hoa%20don%20Neon`;
}
function saveAsFile(fileName, contentBase64) {
    const link = document.createElement('a');
    link.download = fileName;
    link.href = 'data:application/pdf;base64,' + contentBase64;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}

