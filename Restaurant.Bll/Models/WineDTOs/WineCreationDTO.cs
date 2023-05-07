using Restaurant.Bll.Models.MenuPositionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.WineDTOs
{
    public class WineCreationDTO : MenuPositionCreationDTO
    {
        public string Brand { get; set; } = null!;
        public int Year { get; set; }
        public bool IsBottle { get; set; }
        public string RegionName { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string TypeOfWine { get; set; } = null!;
    }
}
