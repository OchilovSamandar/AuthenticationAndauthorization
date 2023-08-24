using AuthenticationAndauthorization.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationAndauthorization.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

    }
}
