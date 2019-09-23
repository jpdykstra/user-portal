using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Seed;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Tests
{

    [TestClass]
    public class InterestSeedTests
    {
        [TestMethod]
        public void SeedLogic_Should_PopulateInterest()
        {
            var interest = new Interest();

            interest = InterestSeedLogic.Instance.Populate(new User());

            Assert.IsTrue(interest.InterestId != Guid.Empty);

            Assert.IsNotNull(interest.Name);

            Assert.IsNotNull(interest.Description);
        }

        [TestMethod]
        public void SeedLogic_Should_PopulateUserList()
        {
            int count = 3;
            var interests = new List<Interest>();

            interests = InterestSeedLogic.Instance.PopulateInterestList(new User(), count).ToList();

            Assert.IsTrue(interests.Count.Equals(count));
        }
    }
}
