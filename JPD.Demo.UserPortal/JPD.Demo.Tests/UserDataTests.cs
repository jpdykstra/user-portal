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
    public class UserDataTests : BaseDataTests
    {
        [TestMethod]
        public void UserData_Should_AddUser_AbeFroman()
        {
            var userData = new UserData(_context);

            var user = new User()
            {
                FirstName = "Abe",
                LastName = "Froman",
                Age = 17,
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
                Name = "Baseball",
                Description = "Wanna have a catch?"
            });

            userData.AddUser(user);

            Assert.IsTrue(user.UserId != Guid.Empty);
        }

        [TestMethod]
        public void UserData_Should_SearchByFirstName_WithJohn()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByFirstName("John");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().FirstName.Trim().ToLower().Equals("john"));
        }

        [TestMethod]
        public void UserData_Should_SearchByLastName_WithDiaz()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByLastName("Diaz");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().LastName.Trim().ToLower().Equals("diaz"));
        }

        [TestMethod]
        public void UserData_Should_SearchByFirstOrLastName_WithLee()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByFirstOrLastName("Lee");

            Assert.IsNotNull(users);

            Assert.IsTrue(users.FirstOrDefault().FirstName.Trim().ToLower().Equals("lee") ||
                          users.FirstOrDefault().LastName.Trim().ToLower().Equals("lee"));
        }

        [TestMethod]
        public void UserData_Should_SearchByFirstAndLastName_WithJohnSmith()
        {
            var userData = new UserData(_context);

            List<User> users = userData.SearchByFirstAndLastName("John", "Smith");

            Assert.IsNotNull(users);
        }
    }
}
