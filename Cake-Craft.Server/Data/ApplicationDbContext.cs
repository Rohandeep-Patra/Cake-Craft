using Cake_Craft.Server.Models;
using Microsoft.EntityFrameworkCore;
namespace Cake_Craft.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
