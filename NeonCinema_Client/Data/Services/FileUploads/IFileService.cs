using Microsoft.AspNetCore.Components.Forms;

namespace NeonCinema_Client.Services.FileUploads
{
    public interface IFileService
    {
        Task UploadFiles(IBrowserFile file);
    }
}
