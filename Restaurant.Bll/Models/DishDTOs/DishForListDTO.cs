using Restaurant.Bll.Models.MenuPositionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.DishDTOs
{
    public class DishForListDTO : MenuPositionForListDTO
    {
        public double Weight { get; set; }
    }
}
