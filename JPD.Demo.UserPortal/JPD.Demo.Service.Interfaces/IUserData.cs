using JPD.Demo.Service.Entities;
using System.Collections.Generic;

namespace JPD.Demo.Service.Interfaces
{
    public interface IUserData
    {
        List<User> GetByFirstName(string firstName);

        List<User> GetByLastName(string LastName);
    }
}
