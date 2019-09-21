using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Interfaces;
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

        public List<User> GetByFirstName(string firstName)
        {
            var users = _context.Users
                .Where(u => u.FirstName.ToLowerInvariant().Equals(firstName.ToLowerInvariant()));

            return users.ToList();
        }

        public List<User> GetByLastName(string lastName)
        {
            var users = _context.Users
                .Where(u => u.LastName.ToLowerInvariant().Equals(lastName.ToLowerInvariant()));

            return users.ToList();
        }
    }
}
