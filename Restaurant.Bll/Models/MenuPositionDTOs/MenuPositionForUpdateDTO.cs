using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.MenuPositionDTOs
{
    public class MenuPositionForUpdateDTO
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string? PhotoLink { get; set; }
    }
}
