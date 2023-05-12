using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("Tables")]
    public class Table
    {
        [Key]
        public int TableNumber { get; set; } 
        public int AmountOfPlaces { get; set; }
        public IEnumerable<InRestaurantOrder> InRestaurantOrders { get; set; } = new List<InRestaurantOrder>();
    }
}
