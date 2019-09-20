using JPD.Demo.Service.Business;
using JPD.Demo.Service.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Tests
{
    [TestClass]
    public class UserSeedTests
    {
        [TestMethod]
        public void ShouldPopulateUser()
        {
            var user = new User();

            user = UserSeedLogic.Instance.Populate();

            Assert.IsTrue(user.UserId != Guid.Empty);

            Assert.IsNotNull(user.FirstName);

            Assert.IsNotNull(user.LastName);

            Assert.IsTrue(user.Age > 0);

            Assert.IsNotNull(user.BillingAddress);

            Assert.IsNotNull(user.MailingAddress);

            Assert.IsNotNull(user.Interests);
        }

        [TestMethod]
        public void ShouldPopulateUserList()
        {
            int count = 5;
            var users = new List<User>();

            users = UserSeedLogic.Instance.PopulateUserList(count).ToList();

            Assert.IsTrue(users.Count.Equals(count));
        }
    }
}
