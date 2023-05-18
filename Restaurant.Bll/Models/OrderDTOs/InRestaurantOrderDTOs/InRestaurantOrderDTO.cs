using Restaurant.Bll.Models.OrderDTOs.DeliveryOrderDTOs;
using Restaurant.Bll.Models.TableDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Models.OrderDTOs.InRestaurantOrderDTOs
{
    public class InRestaurantOrderDTO : OrderDTO
    {
        public TableDTO Table { get; set; } = null!;
    }
}
