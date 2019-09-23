using JPD.Demo.Service.Business;
using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Data;
using JPD.Demo.Service.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JPD.Demo.Tests
{
    [TestClass]
    public class UserLogicTests : BaseDataTests
    {
        [TestMethod]
        public void UserLogic_Should_AddUser_ClarkGriswold()
        {
            var userLogic = new UserLogic(new UserData(_context));

            var user = new User()
            {
                FirstName = "Clark",
                LastName = "Griswold",
                Age = 42,
                Addresses = new List<Address>(),
                Interests = new List<Interest>()
            };

            user.Addresses.Add(new Address()
            {
                AddressType = AddressType.Mailing,
                AddressLine1 = "1060 W Addison St.",
                AddressLine2 = "",
                City = "Chicago",
                State = "IL",
                ZipCode = "60613"
            });

            user.Addresses.Add(new Address()
            {
                AddressType = AddressType.Billing,
                AddressLine1 = "233 S Wacker Drive",
                AddressLine2 = "",
                City = "Chicago",
                State = "IL",
                ZipCode = "60606"
            });

            user.Interests.Add(new Interest()
            {
                Name = "Hanging Christmas Lights",
                Description = "I dedicate this house to the Griswold Family Christmas."
            });

            userLogic.AddUser(user);

            Assert.IsTrue(user.UserId != Guid.Empty);
        }

        [TestMethod]
        public void UserLogic_Should_SearchByFirstName_WithJohn()
        {
            var userLogic = new UserLogic(new UserData(_context));

            List<User> users = userLogic.SearchByFirstName("John");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().FirstName.Trim().ToLower().Equals("john"));
        }

        [TestMethod]
        public void UserLogic_Should_SearchByLastName_WithDiaz()
        {
            var userLogic = new UserLogic(new UserData(_context));

            List<User> users = userLogic.SearchByLastName("Diaz");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().LastName.Trim().ToLower().Equals("diaz"));
        }

        [TestMethod]
        public void UserLogic_Should_SearchByFirstOrLastName_WithLee()
        {
            var userLogic = new UserLogic(new UserData(_context));

            List<User> users = userLogic.SearchByFirstOrLastName("Lee");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().FirstName.Trim().ToLower().Equals("lee") ||
                          users.FirstOrDefault().LastName.Trim().ToLower().Equals("lee"));
        }

        [TestMethod]
        public void UserLogic_Should_SearchByFirstAndLastName_WithJohnSmith()
        {
            var userLogic = new UserLogic(new UserData(_context));

            List<User> users = userLogic.SearchByFirstAndLastName("John", "Smith");

            Assert.IsNotNull(users);
        }
    }
}
