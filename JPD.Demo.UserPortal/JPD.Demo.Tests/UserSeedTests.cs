using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Seed;
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
        public void Should_PopulateUser()
        {
            var user = new User();

            user = UserSeedLogic.Instance.Populate();

            Assert.IsTrue(user.UserId != Guid.Empty);

            Assert.IsNotNull(user.FirstName);

            Assert.IsNotNull(user.LastName);

            Assert.IsTrue(user.Age > 0);
        }

        [TestMethod]
        public void Should_PopulateUserList()
        {
            int count = 5;
            var users = new List<User>();

            users = UserSeedLogic.Instance.PopulateUserList(count).ToList();

            Assert.IsTrue(users.Count.Equals(count));
        }
    }
}
