using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("RegionOfVines")]
    public class RegionOfWine
    {
        [Key]
        public int RegionId { get; set; }
        public string RegionName { get; set; } = null!;
        public string Country { get; set; } = null!;
    }
}
