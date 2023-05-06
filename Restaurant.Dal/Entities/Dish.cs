using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("Dishes")]
    public class Dish : MenuPosition
    {
        public string TypeOfDish { get; set; } = null!;
        public double Weight { get; set; }
    }
}
