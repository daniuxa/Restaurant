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
    public class DrinkService : IDrinkService
    {
        private readonly RestaurantContext _restaurantContext;
        public DrinkService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext ?? throw new ArgumentNullException(nameof(restaurantContext));
        }
        public async Task<Drink> AddDrinkAsync(Guid positionId, Drink drink, string photoLink)
        {
            drink.PositionId = positionId;
            drink.PhotoLink = photoLink;
            await _restaurantContext.Drinks.AddAsync(drink);
            return drink;
        }

        public async Task DeleteAllDrinks()
        {
            _restaurantContext.Drinks.RemoveRange(await _restaurantContext.Drinks.ToListAsync());
        }

        public void DeleteDrink(Drink drink)
        {
            _restaurantContext.Drinks.Remove(drink);
        }

        public async Task<IDictionary<string, IEnumerable<Drink>>> GetDictionaryDrinksAsync()
        {
            IDictionary<string, IEnumerable<Drink>> dictionaryDrinks = new Dictionary<string, IEnumerable<Drink>>();
            IEnumerable<string> typesOfDrink = await _restaurantContext.Drinks.Select(x => x.TypeOfDrink).Distinct().ToListAsync();
            foreach (var type in typesOfDrink)
            {
                dictionaryDrinks.Add(type, await _restaurantContext.Drinks.Where(x => x.TypeOfDrink == type).ToListAsync());
            }
            return dictionaryDrinks;
        }

        public async Task<Drink?> GetDrinkAsync(Guid PositionId)
        {
            Drink? drink = null;
            drink = await _restaurantContext.Drinks.Where(x => x.PositionId == PositionId).FirstOrDefaultAsync();
            return drink;
        }

        public async Task<IEnumerable<Drink>> GetDrinksAsync()
        {
            return await _restaurantContext.Drinks.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _restaurantContext.SaveChangesAsync() >= 0);
        }
    }
}
