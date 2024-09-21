using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using NeonCinema_Application.Interface.FileUpLoad;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.FileUpLoad
{
    public class FileRepo : IFileRepo
    {
        private readonly NeonCinemasContext _context;
        private readonly IWebHostEnvironment _environment;
        public FileRepo(NeonCinemasContext context, IWebHostEnvironment environment)
        {
                _context = context;
            _environment = environment;
        }
        public async Task<int> UploadFiles(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return -1;
            }

            // Chỉ lưu thông tin file vào db
            var fileUpload = new FileUpload
            {
                FileName = file.FileName,
                ContentType = file.ContentType
            };

            _context.FileUploads.Add(fileUpload);
            await _context.SaveChangesAsync();

            return fileUpload.Id;

        }
        private async Task<byte[]> ReadFileContentAsync(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                using (var memorySteam = new MemoryStream()) {
                
                await stream.CopyToAsync(memorySteam);
                    return memorySteam.ToArray();
                }
            }
        }
    }
}
