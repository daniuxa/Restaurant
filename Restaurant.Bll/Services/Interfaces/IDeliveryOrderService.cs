using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    public interface IDeliveryOrderService : IOrderService<DeliveryOrder>
    {
    }
}
