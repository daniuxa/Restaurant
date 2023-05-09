using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    public interface IDrinkService
    {
        Task<IEnumerable<Drink>> GetDrinksAsync();
        Task<Drink?> GetDrinkAsync(Guid PositionId);
        Task<bool> SaveChangesAsync();
        Task<Drink> AddDrinkAsync(Guid positionId, Drink drink, string photoLink);
        Task DeleteAllDrinks();
    }
}
