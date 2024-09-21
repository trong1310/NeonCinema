using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Headers;
namespace NeonCinema_Client.Services.FileUploads
{
    public class FileService : IFileService
    {
        private readonly HttpClient _httpClient;
        public FileService(HttpClient httpClient )
        {
                _httpClient = httpClient;
        }
        public async Task<string> UploadFiles(IBrowserFile file)
        {
            var filePath = Path.Combine("wwwroot", "images", file.Name);
            var fileStream = new FileStream(filePath, FileMode.Create);

            await file.OpenReadStream().CopyToAsync(fileStream);
            fileStream.Close();

            var content = new MultipartFormDataContent();
            var streamContent = new StreamContent(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            streamContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            content.Add(streamContent, "file", file.Name);

            var response = await _httpClient.PostAsync("api/FileUpload/Upload-images", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            return $"/uploads/{file.Name}";  // Đường dẫn ảnh trong Blazor wwwroot
           
        }
    }
}
