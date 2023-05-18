using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.OrderDTOs.DeliveryOrderDTOs
{
    public class DeliveryOrderWithoutClientDTO : OrderWithoutClientDTO
    {
        public string Address { get; set; } = null!;
    }
}
