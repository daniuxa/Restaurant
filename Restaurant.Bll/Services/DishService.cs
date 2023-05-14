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
    public class DishService : IDishService
    {
        private RestaurantContext _restaurantContext;

        public DishService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext ?? throw new ArgumentNullException(nameof(restaurantContext));
        }
        public async Task<Dish> AddDishAsync(Guid positionId, Dish dish, string photoLink)
        {
            dish.PositionId = positionId;
            dish.PhotoLink = photoLink;
            await _restaurantContext.Dishes.AddAsync(dish);
            return dish;
        }

        public async Task DeleteAllDishes()
        {
            _restaurantContext.Dishes.RemoveRange(await _restaurantContext.Dishes.ToListAsync());
        }

        public async Task<IEnumerable<Dish>> GetDishesAsync()
        {
            return await _restaurantContext.Dishes.ToListAsync();
        }

        public async Task<Dish?> GetDishAsync(Guid PositionId)
        {
            Dish? dish = null;
            dish = await _restaurantContext.Dishes.Where(x => x.PositionId == PositionId).FirstOrDefaultAsync();
            return dish;
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _restaurantContext.SaveChangesAsync() >= 0);
        }

        public async Task<IDictionary<string, IEnumerable<Dish>>> GetDictionaryDishesAsync()
        {
            IDictionary<string, IEnumerable<Dish>> dictionaryDishes = new Dictionary<string, IEnumerable<Dish>>();
            IEnumerable<string> typesOfDish = await _restaurantContext.Dishes.Select(x => x.TypeOfDish).Distinct().ToListAsync();
            foreach (var type in typesOfDish)
            {
                dictionaryDishes.Add(type, await _restaurantContext.Dishes.Where(x => x.TypeOfDish == type).ToListAsync());
            }
            return dictionaryDishes;
        }

        public void DeleteDish(Dish dish)
        {
            _restaurantContext.Dishes.Remove(dish);
        }
    }
}
