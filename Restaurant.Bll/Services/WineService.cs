﻿using Microsoft.EntityFrameworkCore;
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

        public async Task<Wine?> GetWineAsync(Guid PositionId)
        {
            Wine? wine = null;
            wine = await _restaurantContext.Wines.Where(x => x.PositionId == PositionId).FirstOrDefaultAsync();
            return wine;
        }

        public async Task<IEnumerable<Wine>> GetWineListAsync()
        {
            return await _restaurantContext.Wines.ToListAsync();
        }

        public async Task<Wine> AddWineAsync(Guid positionId, Wine wine, string photoLink)
        {
            wine.PositionId = positionId;
            wine.PhotoLink = photoLink;
            await _restaurantContext.Wines.AddAsync(wine);
            return wine;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _restaurantContext.SaveChangesAsync() >= 0);
        }

        public async Task DeleteAllWines()
        {
            _restaurantContext.Wines.RemoveRange(await _restaurantContext.Wines.ToListAsync());
        }
    }
}
