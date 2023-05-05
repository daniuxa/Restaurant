using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Dal.Entities
{
    [Table("DeliveryOrders")]
    public class DeliveryOrder : Order
    {
        public string City { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}
