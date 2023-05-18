using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    public interface IOrderService<T> where T: Order 
    {
        Task<T?> GetOrderAsync(int orderId);
        Task<IEnumerable<T>> GetOrdersAsync();
        Task<bool> SaveChangesAsync();
        void DeleteOrder(T order);
        Task DeleteAllOrders();
        Task<T> AddOrderAsync(T order);
    }
}
