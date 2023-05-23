using Restaurant.Bll.Models.MenuPositionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.DrinkDTOs
{
    public class DrinkForListDTO : MenuPositionForListDTO
    {
        public string TypeOfDrink { get; set; } = null!;
        public double Volume { get; set; }
    }
}
