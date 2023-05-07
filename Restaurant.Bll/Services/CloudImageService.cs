using Microsoft.AspNetCore.Http;
using Restaurant.Bll.Services.Interfaces;
using Imagekit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Imagekit.Sdk;

namespace Restaurant.Bll.Services
{
    public class CloudImageService : ICloudImageService
    {
        private readonly ImagekitClient _imagekit;
        private const string publicKey = "public_BICp874xT5H2wmvxDQrJnEv8Ws0=";
        private const string privateKey = "private_Y4BTgSND1kj3z1pcCoSI2X7iVnc=";
        private const string urlEndPoint = "https://ik.imagekit.io/Salivon/Restaurant";
        public CloudImageService()
        {
             _imagekit = new ImagekitClient(publicKey, privateKey, urlEndPoint);
        }
        public async Task<string> UploadImageToCloud(IFormFile file)
        {
            byte[] fileBytes;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileBytes = ms.ToArray();
            }
            FileCreateRequest ob = new FileCreateRequest
            {
                file = fileBytes,
                fileName = file.Name
            };
            Result result = await _imagekit.UploadAsync(ob);
            return result.url;
        }
    }
}
