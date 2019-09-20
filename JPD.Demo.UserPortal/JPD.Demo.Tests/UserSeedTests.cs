using JPD.Demo.Service.Business;
using JPD.Demo.Service.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
        }
    }
}
