﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("Wines")]
    public class Wine : MenuPosition
    {
        public string Brand { get; set; } = null!;
        public int Year { get; set; }
        public bool IsBottle { get; set; }
        public string TypeOfWine { get; set; } = null!;
        public string Country { get; set; }
        public string RegionName { get; set; }
    }
}
