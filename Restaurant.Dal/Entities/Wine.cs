using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("Vines")]
    public class Wine : MenuPosition
    {
        public string Brand { get; set; } = null!;
        public int Year { get; set; }
        public bool IsBottle { get; set; }
        [ForeignKey("RegionId")]
        public RegionOfWine Region { get; set; } = null!;
        public int RegionId { get; set; }
        public string TypeOfWine { get; set; } = null!;
    }
}
