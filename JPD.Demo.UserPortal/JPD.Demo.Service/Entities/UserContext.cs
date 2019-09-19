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



            modelBuilder.Entity<Interest>().HasData(
               new Interest
            {
                InterestId = Guid.NewGuid(),
                Name = "Hiking",
                Description = "Going for long walks in the country or woods."

            }, new Interest
            {
                InterestId = Guid.NewGuid(),
                Name = "Skiing",
                Description = "Traveling over the snow on skis."
            }); 
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Interest> Interests { get; set; }
    }
}
