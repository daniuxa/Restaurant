using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    public interface ICloudImageService
    {
        Task<(Guid, string)> UploadImageToCloud(IFormFile file, string folderName = "");
    }
}
