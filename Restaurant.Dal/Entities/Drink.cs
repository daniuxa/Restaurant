using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("Drinks")]
    public class Drink : MenuPosition
    {
        public string TypeOfDrink { get; set; } = null!;
        public double Volume { get; set; }
    }
}
