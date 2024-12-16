namespace NeonCinema_API.SendMail.Template
{
    public class CreateUser
    {
        public static string CreateClient(string fullName, string Email, string Password)
        {
            return $@"
            <div style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                <div style='background-color: #f8f9fa; padding: 20px; border: 1px solid #ddd; border-radius: 8px;'>
                    <h2 style='color: #ff5733; text-align: center;'>Chào mừng đến với NeonCinema! 🌟</h2>
                    <p>Xin chào <strong>{fullName}</strong>,</p>
                    <p>Thông tin tài khoản của bạn:</p>
                    <ul>
                                    <li><strong>Email:</strong> {Email}</li>
                                    <li><strong>Mật khẩu:</strong> {Password}</li>
                    </ul>            
                    <p>Cảm ơn bạn đã tin tưởng và lựa chọn rạp chiếu phim NeonCinema. Chúng tôi rất vui mừng được chào đón bạn trở thành một phần của cộng đồng yêu phim tuyệt vời này.</p>
                    <p>Với tài khoản của mình, bạn có thể:</p>
                    <ul>
                        <li>Đặt vé xem phim trực tuyến nhanh chóng và tiện lợi.</li>
                        <li>Nhận thông báo về các bộ phim mới nhất và các chương trình ưu đãi hấp dẫn.</li>
                        <li>Tham gia vào các sự kiện độc quyền dành riêng cho thành viên.</li>
                    </ul>
                    <p>Hãy truy cập website của chúng tôi để bắt đầu trải nghiệm điện ảnh không giới hạn!</p>
                    <p>Nếu bạn cần hỗ trợ, đừng ngần ngại liên hệ với chúng tôi qua email hoặc số điện thoại hỗ trợ. Chúng tôi luôn sẵn sàng lắng nghe và hỗ trợ bạn.</p>
                    <p style='margin-top: 20px;'>Một lần nữa, chào mừng bạn đến với NeonCinema. Chúc bạn có những giây phút tuyệt vời bên màn ảnh! 🎬</p>
                    <p style='font-style: italic;'>Trân trọng,</p>
                    <p><strong>Đội ngũ NeonCinema</strong></p>
                    <p> Xin cám ơn 😊</p>
                </div>
            </div>";
        }
        public static string CreateStaff(string fullName, string Email, string Password)
        {
            return $@"
            <div style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                <div style='background-color: #f8f9fa; padding: 20px; border: 1px solid #ddd; border-radius: 8px;'>
                    <h2 style='color: #ff5733; text-align: center;'>Chào mừng đến với NeonCinema! 🌟</h2>
                    <p>Xin chào <strong>{fullName}</strong>,</p>
                    <p>Chúng tôi rất vui mừng chào đón bạn gia nhập đội ngũ <strong>NeonCinema</strong>.</p>
                    <p>Dưới đây là thông tin tài khoản của bạn:</p>
                    <ul>
                                    <li><strong>Email:</strong> {Email}</li>
                                    <li><strong>Mật khẩu:</strong> {Password}</li>
                    </ul>            
                     <p>Với tài khoản này, bạn có thể:</p>
                    <ul>
                        <li>Truy cập hệ thống quản lý nội bộ.</li>
                        <li>Quản lý và theo dõi các hoạt động tại rạp.</li>
                        <li>Nhận thông báo và tham gia các buổi đào tạo từ công ty.</li>
                    </ul>
                    <p>Chúng tôi tin rằng sự gia nhập của bạn sẽ mang lại nhiều giá trị cho đội ngũ NeonCinema. Nếu cần hỗ trợ hoặc có bất kỳ thắc mắc nào, đừng ngần ngại liên hệ với bộ phận nhân sự hoặc IT.</p>
                    <p>Chúc bạn có một khởi đầu thật tốt đẹp và cùng chúng tôi tạo nên những trải nghiệm điện ảnh tuyệt vời cho khách hàng! 🎬</p>
                    <p style='font-style: italic;'>Trân trọng,</p>
                    <p><strong>Đội ngũ NeonCinema</strong></p>
                    <p> Xin cám ơn 😊</p>
                </div>
            </div>";
        }

        public static string ForgotPassword(string fullName, string password)
        {
            return $@"
            <div style='font-family: Arial, sans-serif; line-height: 1.6; color: #333;'>
                <div style='background-color: #f8f9fa; padding: 20px; border: 1px solid #ddd; border-radius: 8px;'>
                    <h2 style='color: #ff5733; text-align: center;'>Chào mừng đến với NeonCinema! 🌟</h2>
                    <p>Xin chào <strong>{fullName}</strong>,</p>
                    <p>Chúng tôi nhận được yêu cầu đặt lại mật khẩu cho tài khoản của bạn.</p>
                    <p>Dưới đây là mật khẩu mới của bạn:</p>
                    <ul>
                                    <li><strong>Mật khẩu:</strong> {password}</li>
                    </ul>            
                    <p style='font-style: italic;'>Trân trọng,</p>
                    <p><strong>Đội ngũ NeonCinema</strong></p>
                    <p> Xin cám ơn 😊</p>
                </div>
            </div>";
        }
    }
}
