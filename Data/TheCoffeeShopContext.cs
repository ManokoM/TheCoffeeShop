using Microsoft.EntityFrameworkCore;
using TheCoffeeShop.Models;
using Microsoft.EntityFrameworkCore;

namespace TheCoffeeShop.Data
{
    public class TheCoffeeShopContext:DbContext
    {
        public TheCoffeeShopContext(DbContextOptions<TheCoffeeShopContext> options)
    : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
