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
    public class WineService : IWineService
    {
        private readonly RestaurantContext _restaurantContext;

        public WineService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext ?? throw new ArgumentNullException(nameof(restaurantContext));
        }

        public async Task<IEnumerable<Wine>> GetWineListAsync()
        {
            return await _restaurantContext.Wines.Include(x => x.Region).ToListAsync();
        }
    }
}
