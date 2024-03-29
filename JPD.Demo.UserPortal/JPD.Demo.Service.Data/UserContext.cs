﻿using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Common.Helpers;
using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Seed;
using JPD.Demo.Service.Seed.Factories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Service.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<User> users = UserSeedLogic.Instance.PopulateUserList(200).ToList();

            modelBuilder.Entity<User>().HasData(users);

            foreach (var user in users)
            {
                modelBuilder.Entity<Interest>().HasData(InterestSeedLogic.Instance.PopulateInterestList(user, RandomHelper.GetRandomShort(1, 6)));
                modelBuilder.Entity<Address>().HasData(AddressSeedFactory.Create(AddressType.Mailing).Populate(user));
                modelBuilder.Entity<Address>().HasData(AddressSeedFactory.Create(AddressType.Billing).Populate(user));
            }
        }

        public DbSet<User> Users { get; set; }
    }
}
