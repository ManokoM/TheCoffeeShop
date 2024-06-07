using TheCoffeeShop.Models;

namespace TheCoffeeShop.Services
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetClients();
        Task<Client> GetClient(int id);
        Task<Client> AddClient(Client client);
        Task UpdateClient(Client client);
        Task DeleteClient(int id);
    }
}
