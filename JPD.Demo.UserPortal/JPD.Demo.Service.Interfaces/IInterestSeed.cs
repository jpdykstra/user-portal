using JPD.Demo.Service.Entities;
using System.Collections.Generic;

namespace JPD.Demo.Service.Interfaces
{
    public interface IInterestSeed
    {
        Interest Populate(User user);

        ICollection<Interest> PopulateInterestList(User user, int count);
    }
}
