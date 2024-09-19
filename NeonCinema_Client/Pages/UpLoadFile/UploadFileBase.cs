using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using NeonCinema_Client.Services.FileUploads;

namespace NeonCinema_Client.Pages.UpLoadFile
{
    public class UploadFileBase : ComponentBase
    {
        [Inject]
        public IFileService FileService { get; set; }

        public List<IBrowserFile> files { get; set; } = new List<IBrowserFile>();

        protected async Task InputFileChange(InputFileChangeEventArgs e)
        {
            files.Clear(); // Xóa danh sách tệp trước khi thêm mới
            files.AddRange(e.GetMultipleFiles(e.FileCount)); // Thêm các tệp mới
        }

        protected async Task Upload()
        {
            foreach (var file in files)
            {
                try
                {
                    await FileService.UploadFiles(file); // Gọi dịch vụ tải lên
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ: thông báo cho người dùng hoặc log lỗi
                    Console.WriteLine($"Error uploading file {file.Name}: {ex.Message}");
                }
            }
        }
    }
}
