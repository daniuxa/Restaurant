using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.MenuPositionDTOs
{
    public class MenuPositionCreationDTO
    {
        public decimal Price { get; set; }
        public string Name { get; set; } = null!;
        public IFormFile photo { get; set; }
    }
}
