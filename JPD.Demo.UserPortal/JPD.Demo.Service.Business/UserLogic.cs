using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Interfaces;
using System.Collections.Generic;

namespace JPD.Demo.Service.Business
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserData _userData;

        public UserLogic(IUserData userData)
        {
            _userData = userData;
        }

        public void AddUser(User user)
        {
            _userData.AddUser(user);
        }

        public List<User> SearchByFirstAndLastName(string firstName, string lastName)
        {
            return _userData.SearchByFirstAndLastName(firstName, lastName);
        }

        public List<User> SearchByFirstName(string firstName)
        {
           return _userData.SearchByFirstName(firstName);
        }

        public List<User> SearchByFirstOrLastName(string name)
        {
           return _userData.SearchByFirstOrLastName(name);
        }

        public List<User> SearchByLastName(string lastName)
        {
            return _userData.SearchByLastName(lastName);
        }
    }
}
