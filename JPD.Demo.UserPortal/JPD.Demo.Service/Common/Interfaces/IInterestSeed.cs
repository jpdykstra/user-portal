using JPD.Demo.Service.Entities;
using System.Collections.Generic;

namespace JPD.Demo.Service.Common.Interfaces
{
    public interface IInterestSeed
    {
        Interest Populate();

        ICollection<Interest> PopulateInterestList(int count);
    }
}
