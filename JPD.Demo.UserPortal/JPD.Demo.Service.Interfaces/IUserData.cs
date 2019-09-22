using JPD.Demo.Service.Entities;
using System;
using System.Collections.Generic;

namespace JPD.Demo.Service.Interfaces
{
    public interface IUserData
    {
        List<User> SearchByNames(string[] names);

        List<User> SearchByFirstOrLastName(string name);

        List<User> SearchByFirstName(string firstName);

        List<User> SearchByLastName(string LastName);

        void AddUser(User user);
    }
}
