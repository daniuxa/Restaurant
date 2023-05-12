using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    public interface IWineService
    {
        Task<IEnumerable<Wine>> GetWinesAsync();
        Task<IDictionary<string, IEnumerable<Wine>>> GetDictionaryWinesAsync();
        Task<Wine?> GetWineAsync(Guid PositionId);
        Task<bool> SaveChangesAsync();
        Task<Wine> AddWineAsync(Guid positionId, Wine wine, string photoLink);
        Task DeleteAllWines();
    }
}
