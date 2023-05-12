using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.DishDTOs
{
    public class DishDictionaryDTO
    {
        public string TypeOfDish { get; set; }
        public IEnumerable<DishForListDTO> Dishes { get; set; }
    }
}
