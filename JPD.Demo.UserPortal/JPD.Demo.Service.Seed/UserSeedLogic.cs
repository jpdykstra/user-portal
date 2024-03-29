﻿using JPD.Demo.Service.Common.Helpers;
using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace JPD.Demo.Service.Seed
{
    public class UserSeedLogic : IUserSeed
    {
        private static UserSeedLogic instance;

        private UserSeedLogic() { }

        public static UserSeedLogic Instance
        {
            get
            {
                if (instance == null) { instance = new UserSeedLogic(); }

                return instance;
            }
        }

        public User Populate()
        {
            var user = new User();

            user.UserId = Guid.NewGuid();
            user.FirstName = RandomHelper.GetRandomString(GetFirstNames);
            user.LastName = RandomHelper.GetRandomString(GetLastNames);
            user.Age = RandomHelper.GetRandomShort(18,85);

            return user;
        }

        public ICollection<User> PopulateUserList(int count)
        {
            int i = 0;
            var users = new List<User>();

            while (i < count)
            {
                users.Add(Populate());
                i++;
            }

            return users;
        }

        private List<string> GetFirstNames()
        {
            var firstNames = new List<string>()
            {
                "James",
                "Mary",
                "John",
                "Patricia",
                "Pedro",
                "Jennifer",
                "Michael",
                "Linda",
                "William",
                "Elizabeth",
                "Juan",
                "Barbara",
                "Richard",
                "Martina",
                "Joseph",
                "Jessica",
                "Thomas",
                "Sara",
                "Charles",
                "Catalina",
                "Evan",
                "Lee"
            };

            return firstNames;
        }

        private List<string> GetLastNames()
        {
            var lastNames = new List<string>()
            {
               "Smith",
               "Johnson",
               "Hall",
               "Sanchez",
               "Bennett",
               "Reed",
               "Powell",
               "Rivera",
               "Bailey",
               "Anderson",
               "Watson",
               "Garcia",
               "Lee",
               "Walker",
               "Hayes",
               "Diaz",
               "Washington",
               "Collins",
               "Roberts",
               "Martin",
               "Clark"
            };

            return lastNames;
        }
    }
}
