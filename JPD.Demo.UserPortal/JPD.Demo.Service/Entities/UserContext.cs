using JPD.Demo.Service.Business;
using JPD.Demo.Service.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace JPD.Demo.Service.Entities
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(a => a.AddressType)
                .HasConversion<int>();

            modelBuilder.Entity<User>().HasData(UserSeedLogic.Instance.PopulateUserList(20));
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Interest> Interests { get; set; }
    }
}
