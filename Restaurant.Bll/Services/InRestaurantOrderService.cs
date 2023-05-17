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
    public class InRestaurantOrderService : IInRestaurantOrderService
    {
        private readonly RestaurantContext _restaurantContext;

        public InRestaurantOrderService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext;
        }
        public async Task<InRestaurantOrder> AddOrderAsync(InRestaurantOrder order)
        {
            await _restaurantContext.InRestaurantOrders.AddAsync(order);
            return order;
        }

        public void DeleteOrder(InRestaurantOrder order)
        {
            _restaurantContext.InRestaurantOrders.Remove(order);
        }

        public async Task<InRestaurantOrder?> GetOrderAsync(int orderId)
        {
            InRestaurantOrder? order = null;
            order = await _restaurantContext.InRestaurantOrders.Where(x => x.OrderId == orderId).FirstOrDefaultAsync();
            return order;
        }

        public async Task<IEnumerable<InRestaurantOrder>> GetOrdersAsync()
        {
            return await _restaurantContext.InRestaurantOrders.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _restaurantContext.SaveChangesAsync() >= 0);
        }
    }
}
