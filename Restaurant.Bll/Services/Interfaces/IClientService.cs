using Restaurant.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Bll.Services.Interfaces
{
    public interface IClientService
    {
        Task<Client> AddClientAsync(Client client);
        Task<bool> SaveChangesAsync();
        Task<Client?> GetClientAsync(int clientId);
        Task<IEnumerable<Client>> GetClientsAsync();
    }
}
