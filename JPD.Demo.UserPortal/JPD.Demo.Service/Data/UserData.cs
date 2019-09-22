﻿using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Service.Data
{
    public class UserData : IUserData
    {
        private readonly UserContext _context;

        public UserData(UserContext context)
        {
            _context = context;
        }

        public List<User> SearchByNames(string[] names)
        {
            var users = new List<User>();

            if (names.Length.Equals(2))
            {
                var result = _context.Users
                    .AsNoTracking()
                    .Include(a => a.Addresses)
                    .Include(i => i.Interests)
                    .Where(u => u.FirstName.ToLowerInvariant().Equals(names[0].Trim().ToLowerInvariant()) &&
                    u.LastName.ToLowerInvariant().Equals(names[1].Trim().ToLowerInvariant()));

                users = result.ToList();
            }

            return users;
        }

        public List<User> SearchByFirstOrLastName(string name)
        {
            var users = _context.Users
                .AsNoTracking()
                .Include(a => a.Addresses)
                .Include(i => i.Interests)
                .Where(u => u.FirstName.ToLowerInvariant().Equals(name.Trim().ToLowerInvariant()) ||
                            u.LastName.ToLowerInvariant().Equals(name.Trim().ToLowerInvariant()));

            return users.ToList();
        }

        public List<User> SearchByFirstName(string name)
        {
            var users = _context.Users
                .AsNoTracking()
                .Include(a => a.Addresses)
                .Include(i => i.Interests)
                .Where(u => u.FirstName.ToLowerInvariant().Equals(name.Trim().ToLowerInvariant()));

            return users.ToList();
        }

        public List<User> SearchByLastName(string lastName)
        {
            var users = _context.Users
                .AsNoTracking()
                .Include(a => a.Addresses)
                .Include(i => i.Interests)
                .Where(u => u.LastName.ToLowerInvariant().Equals(lastName.Trim().ToLowerInvariant()));

            return users.ToList();
        }

        public void AddUser(User user)
        {
            user.UserId = Guid.NewGuid();

            _context.Add(user);
            _context.SaveChanges();
        }
    }
}
