using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("TakeAwayOrders")]
    public class TakeAwayOrder : Order
    {
        public DateTime TimePickUp { get; set; }
    }
}
