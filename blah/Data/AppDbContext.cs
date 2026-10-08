using blah.Models;
using Microsoft.EntityFrameworkCore;

namespace blah.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<UserAccount> UserAccounts => Set<UserAccount>();
        public DbSet<CartItem> CartItems => Set<CartItem>();
    }
}
