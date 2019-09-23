using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Interfaces;
using JPD.Demo.Service.Seed;
using JPD.Demo.Service.Seed.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JPD.Demo.Tests
{
    [TestClass]
    public class AddressSeedTests
    {
        [TestMethod]
        public void SeedLogic_Should_ReturnMailingAddress_Class()
        {
            IAddressSeed addressLogic = AddressSeedFactory.Create(AddressType.Mailing);

            Assert.IsInstanceOfType(addressLogic, typeof(MailingAddressSeedLogic));
        }

        [TestMethod]
        public void SeedLogic_Should_ReturnBillingAddress_Class()
        {
            IAddressSeed addressLogic = AddressSeedFactory.Create(AddressType.Billing);

            Assert.IsInstanceOfType(addressLogic, typeof(BillingAddressSeedLogic));
        }

        [TestMethod]
        public void SeedLogic_Should_PopulateMailingAddress()
        {
            var address = new Address();
            var addressSeedLogic = new MailingAddressSeedLogic();

            address = addressSeedLogic.Populate(new User());

            Assert.IsTrue(address.AddressId != Guid.Empty);

            Assert.IsTrue(address.AddressType.Equals(AddressType.Mailing));

            Assert.IsNotNull(address.AddressLine1);

            Assert.IsNotNull(address.City);

            Assert.IsNotNull(address.State);

            Assert.IsNotNull(address.ZipCode);
        }

        [TestMethod]
        public void SeedLogic_Should_PopulateBillingAddress()
        {
            var address = new Address();
            var addressSeedLogic = new BillingAddressSeedLogic();

            address = addressSeedLogic.Populate(new User());

            Assert.IsTrue(address.AddressId != Guid.Empty);

            Assert.IsTrue(address.AddressType.Equals(AddressType.Billing));

            Assert.IsNotNull(address.AddressLine1);

            Assert.IsNotNull(address.City);

            Assert.IsNotNull(address.State);

            Assert.IsNotNull(address.ZipCode);
        }
    }
}
