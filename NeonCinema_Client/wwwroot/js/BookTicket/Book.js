function thaydoitongtien(amount) {
    const qrcode = document.getElementById("qrcode");
    const accountName = "NGUYEN VAN TRONG";
    qrcode.src = `https://api.vietqr.io/image/970418-1160087273-TDqOAw1.jpg?accountName=${accountName}&amount=${amount}&addInfo=Thanh%20toan%20hoa%20don%20Neon`;
}
