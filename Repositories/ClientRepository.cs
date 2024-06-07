using Microsoft.EntityFrameworkCore;
using TheCoffeeShop.Data;
using TheCoffeeShop.Models;

namespace TheCoffeeShop.Services
{
    public class ClientRepository
    {
        private readonly TheCoffeeShopContext _context;

        public ClientRepository(TheCoffeeShopContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetClients()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetClient(int id)
        {
            return await _context.Clients.FindAsync(id);
        }

        public async Task<Client> AddClient(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }

        public async Task UpdateClient(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
        }
    }
}
