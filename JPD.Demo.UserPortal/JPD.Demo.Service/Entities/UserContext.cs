using JPD.Demo.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace JPD.Demo.Service.Entities
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.Migrate();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Interest> Interests { get; set; }
    }
}
