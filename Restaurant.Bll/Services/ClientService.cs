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
    public class ClientService : IClientService
    {
        private readonly RestaurantContext _restaurantContext;

        public ClientService(RestaurantContext restaurantContext)
        {
            this._restaurantContext = restaurantContext;
        }
        public async Task<Client> AddClientAsync(Client client)
        {
            await _restaurantContext.Clients.AddAsync(client);
            return client;
        }

        public async Task<Client?> GetClientAsync(int clientId)
        {
            Client? client = null;
            client = await _restaurantContext.Clients.Where(x => x.ClientId == clientId).FirstOrDefaultAsync();
            return client;
        }

        public async Task<IEnumerable<Client>> GetClientsAsync()
        {
            return await _restaurantContext.Clients.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _restaurantContext.SaveChangesAsync() >= 0);
        }

    }
}
