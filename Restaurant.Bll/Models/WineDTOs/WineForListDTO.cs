using Restaurant.Bll.Models.MenuPositionDTOs;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.WineDTOs
{
    public class WineForListDTO : MenuPositionForListDTO
    {
        public bool IsBottle { get; set; }
        public string RegionName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string TypeOfWine { get; set; } = null!;
    }
}
