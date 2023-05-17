using Microsoft.EntityFrameworkCore;
using Restaurant.Bll.Services.Interfaces;
using Restaurant.Dal.Contexts;
using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services
{
    public class DeliveryOrderService : IDeliveryOrderService
    {
        private readonly RestaurantContext _restaurantContext;

        public DeliveryOrderService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext ?? throw new ArgumentNullException(nameof(restaurantContext));
        }
        public async Task<DeliveryOrder> AddOrderAsync(DeliveryOrder order)
        {
            await _restaurantContext.DeliveryOrders.AddAsync(order);
            return order;
        }

        public void DeleteOrder(DeliveryOrder order)
        {
            _restaurantContext.DeliveryOrders.Remove(order);
        }

        public async Task<DeliveryOrder?> GetOrderAsync(int orderId)
        {
            DeliveryOrder? order = null;
            order = await _restaurantContext.DeliveryOrders.Where(x => x.OrderId == orderId).FirstOrDefaultAsync();
            return order;
        }

        public async Task<IEnumerable<DeliveryOrder>> GetOrdersAsync()
        {
            return await _restaurantContext.DeliveryOrders.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _restaurantContext.SaveChangesAsync() >= 0);
        }
    }
}
