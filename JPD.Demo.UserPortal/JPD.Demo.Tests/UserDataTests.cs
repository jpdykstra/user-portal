using JPD.Demo.Service.Data;
using JPD.Demo.Service.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Tests
{
    [TestClass]
    public class UserDataTests : BaseDataTests
    {
        public void AddUser()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Should_SearchByFirstName_WithJohn()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByFirstName("John");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().FirstName.Trim().ToLower().Equals("john"));
        }

        [TestMethod]
        public void Should_SearchByLastName_WithDiaz()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByLastName("Diaz");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().LastName.Trim().ToLower().Equals("diaz"));
        }

        [TestMethod]
        public void Should_SearchByFirstOrLastName_WithLee()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByFirstOrLastName("Lee");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().FirstName.Trim().ToLower().Equals("lee") ||
                          users.FirstOrDefault().LastName.Trim().ToLower().Equals("lee"));
        }

        [TestMethod]
        public void Should_SearchByFirstAndLastName_WithJohnSmith()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByFirstAndLastName("John", "Smith");

            Assert.IsNotNull(users);
        }
    }
}
