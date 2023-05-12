using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("InRestaurantOrders")]
    public class InRestaurantOrder : Order
    {
        public int AmountOfGuests { get; set; }
        [ForeignKey("TableNumber")]
        public Table Table { get; set; } = null!;
        public int TableNumber { get; set; }
    }
}
