using JPD.Demo.Service.Business;
using JPD.Demo.Service.Business.Factories;
using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Entities;
using JPD.Demo.Service.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace JPD.Demo.Tests
{
    [TestClass]
    public class AddressSeedTests
    {
        [TestMethod]
        public void ShouldCreateMailingAddressSeedLogic()
        {
            IAddressSeed addressLogic = AddressSeedFactory.Create(AddressType.Mailing);

            Assert.IsTrue(addressLogic.GetType().Equals(typeof(MailingAddressSeedLogic)));
        }

        public void ShouldCreateBillingAddressSeedLogic()
        {
            IAddressSeed addressLogic = AddressSeedFactory.Create(AddressType.Billing);

            Assert.IsTrue(addressLogic.GetType().Equals(typeof(BillingAddressSeedLogic)));
        }

        [TestMethod]
        public void ShouldPopulateMailingAddress()
        {
            var address = new Address();
            var addressSeedLogic = new MailingAddressSeedLogic();

            address = addressSeedLogic.Populate();

            Assert.IsTrue(address.AddressId != Guid.Empty);

            Assert.IsTrue(address.AddressType.Equals(AddressType.Mailing));

            Assert.IsNotNull(address.AddressLine1);

            Assert.IsNotNull(address.City);

            Assert.IsNotNull(address.State);

            Assert.IsNotNull(address.ZipCode);
        }

        [TestMethod]
        public void ShouldPopulateBillingAddress()
        {
            var address = new Address();
            var addressSeedLogic = new BillingAddressSeedLogic();

            address = addressSeedLogic.Populate();

            Assert.IsTrue(address.AddressId != Guid.Empty);

            Assert.IsTrue(address.AddressType.Equals(AddressType.Billing));

            Assert.IsNotNull(address.AddressLine1);

            Assert.IsNotNull(address.City);

            Assert.IsNotNull(address.State);

            Assert.IsNotNull(address.ZipCode);
        }

    }
}
