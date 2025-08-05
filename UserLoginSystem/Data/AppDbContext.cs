using UserLoginSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace UserLoginSystem.Data
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}

