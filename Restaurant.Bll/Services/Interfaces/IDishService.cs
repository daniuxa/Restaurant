﻿using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    public interface IDishService
    {
        Task<IEnumerable<Dish>> GetDishesAsync();
        Task<Dish?> GetDishAsync(Guid PositionId);
        Task<bool> SaveChangesAsync();
        Task<Dish> AddDishAsync(Guid positionId, Dish wine, string photoLink);
        Task DeleteAllDishes();
    }
}