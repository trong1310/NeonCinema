using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.FileUpLoad
{
    public interface IFileRepo
    {
        Task<int> UploadFiles(IFormFile file);
    }
}
