using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Common.Helpers;
using JPD.Demo.Service.Interfaces;
using JPD.Demo.Service.Entities;
using System;
using System.Collections.Generic;

namespace JPD.Demo.Service.Business
{
    public abstract class AddressSeedLogicBase : IAddressSeed
    {
        public Address Populate()
        {
            var address = new Address();

            address.AddressId = Guid.NewGuid();
            address.AddressLine1 = RandomHelper.GetRandomString(GetAddressLine1);
            address.AddressLine2 = RandomHelper.GetRandomString(GetAddressLine2);
            address.City = RandomHelper.GetRandomString(GetCities);
            address.State = RandomHelper.GetRandomString(GetStates);
            address.ZipCode = RandomHelper.GetRandomString(GetZipCodes);

            return address;
        }

        public abstract AddressType AddressType { get; }

        protected abstract List<string> GetAddressLine1();

        protected abstract List<string> GetAddressLine2();

        private List<string> GetCities()
        {
            var cities = new List<string>()
            {
                "Shermer",
                "Northbrook",
                "Glenbrook North",
                "Winnetka",
                "Emerald City",
                "Metropolis",
                "Gotham City",
                "Cloud City",
                "Gugan City",
                "Mos Eisely",
                "Godric's Hollow",
                "Riverside",
                "Springfield",
                "Boulder",
                "Bountiful",
                "Copperton",
                "Bryce Canyon City"
            };

            return cities;
        }

        private List<string> GetStates()
        {
            var states = new List<string>
            {
                "AL",
                "Ak",
                "AZ",
                "AR",
                "CA",
                "CO",
                "CT",
                "DE",
                "FL",
                "UT"
            };

            return states;
        }

        protected List<string> GetZipCodes()
        {
            var states = new List<string>
            {
                "35004",
                "35005",
                "35006",
                "99501",
                "99504",
                "85001",
                "85003",
                "71602",
                "71603",
                "90001",
                "90003",
                "80011",
                "80019",
                "06001",
                "06002",
                "19702",
                "19706",
                "32003",
                "32006",
                "84101",
                "84103"
            };

            return states;
        }
    }
}
