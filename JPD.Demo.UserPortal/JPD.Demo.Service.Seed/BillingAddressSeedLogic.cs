using JPD.Demo.Service.Common.Enums;
using System.Collections.Generic;

namespace JPD.Demo.Service.Seed
{
    public class BillingAddressSeedLogic : AddressSeedLogicBase
    {
        public override AddressType AddressType => AddressType.Billing;

        protected override List<string> GetAddressLine1()
        {
            var addresslines = new List<string>()
            {
                "1640 Riverside Drive",
                "84 Beacon Street",
                "1882 Gerard Street",
                "4 Privet Drive",
                "711 Maple Street",
                "1313 Mockingbird Lane",
                "124 Conch Street",
                "3170 W. 53 Rd",
                "1407 Graymalkin Lane",
                "221B Baker Street",
                "714 Delaware",
                "129 West 81st Street",
                "9764 Jeoprardy Lane",
                "1060 W Addison St.",
                "370 Beech Street",
                "2300 Shermer Road",
                "233 South Wacker Drive"
            };

            return addresslines;
        }

        protected override List<string> GetAddressLine2()
        {
            var addresslines = new List<string>()
            {
                "",
                "Apartment 5A",
                "Suite 305",
                "Suite 905",
                "Apt 4",
                "5th Floor",
                "Apt 201"
            };

            return addresslines;
        }
    }
}
