using JPD.Demo.Service.Business;
using JPD.Demo.Service.Entities;
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
        public void ShouldPopulateInterest()
        {
            var interest = new Interest();

            interest = InterestSeedLogic.Instance.Populate();

            Assert.IsTrue(interest.InterestId != Guid.Empty);

            Assert.IsNotNull(interest.Name);

            Assert.IsNotNull(interest.Description);
        }

        [TestMethod]
        public void ShouldPopulateUserList()
        {
            int count = 3;
            var interests = new List<Interest>();

            interests = InterestSeedLogic.Instance.PopulateInterestList(count).ToList();

            Assert.IsTrue(interests.Count.Equals(count));
        }
    }
}
