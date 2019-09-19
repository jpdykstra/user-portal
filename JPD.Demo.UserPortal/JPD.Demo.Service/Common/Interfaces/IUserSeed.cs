using JPD.Demo.Service.Entities;
using System.Collections.Generic;

namespace JPD.Demo.Service.Common.Interfaces
{
    public interface IUserSeed
    {
        User Populate();

        ICollection<User> PopulateUserList(int count);
    }
}
