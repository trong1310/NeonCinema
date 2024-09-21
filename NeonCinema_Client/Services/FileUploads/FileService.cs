using Microsoft.AspNetCore.Components.Forms;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
namespace NeonCinema_Client.Services.FileUploads
{
    public class FileService : IFileService
    {
        private readonly HttpClient _httpClient;

        public FileService(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }
        public async Task<string> UploadFiles(IBrowserFile file)
        {
            var content = new MultipartFormDataContent();
            var streamContent = new StreamContent(file.OpenReadStream(file.Size));

            streamContent.Headers.ContentType = new MediaTypeHeaderValue(file.ContentType);
            content.Add(streamContent, "file", file.Name);

            var response = await _httpClient.PostAsync("api/FileUpload/Upload-images", content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(await response.Content.ReadAsStringAsync());
            }

            // Trả về URL của file đã upload
            return await response.Content.ReadAsStringAsync();
        }
    }
}
