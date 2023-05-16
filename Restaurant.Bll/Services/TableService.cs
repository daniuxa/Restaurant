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
    public class TableService : ITableService
    {
        private readonly RestaurantContext _restaurantContext;

        public TableService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext ?? throw new ArgumentNullException(nameof(restaurantContext));
        }
        public async Task<Table> AddTableAsync(Table table)
        {
            await _restaurantContext.Tables.AddAsync(table);
            return table;
        }

        public async Task DeleteAllTables()
        {
            _restaurantContext.Tables.RemoveRange(await _restaurantContext.Tables.ToListAsync());
        }

        public async Task<Table?> GetTableAsync(int tableNumber)
        {
            Table? table = await _restaurantContext.Tables.Where(x => x.TableNumber == tableNumber).FirstOrDefaultAsync();
            return table;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _restaurantContext.SaveChangesAsync() >= 0);
        }
    }
}
