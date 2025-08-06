using UserLoginSystem.Core;
using Microsoft.EntityFrameworkCore;

namespace UserLoginSystem.Core.Data
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}

