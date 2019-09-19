using JPD.Demo.Service.Common.Enums;
using System.Collections.Generic;

namespace JPD.Demo.Service.Business
{
    public class MailingAddressSeedLogic : AddressSeedLogicBase
    {
        public override AddressType AddressType => AddressType.Mailing;

        protected override List<string> GetAddressLine1()
        {
            var addresslines = new List<string>()
            {
                "PO Box 12345",
                "PO Box 15458",
                "PO Box 49003",
                "PO Box 65478",
                "PO Box 45789",
                "PO Box 96325",
                "15 Evergreen Terrace",
                "1202 Paper Street",
                "123 Sesame Street",
                "97 Rainey Street",
                "1 Avenue Q",
                "45 Spooner Street",
                "173 Esses Drive",
                "320 Fowler Street",
                "565 N. Clinton Drive"
            };

            return addresslines;
        }

        protected override List<string> GetAddressLine2()
        {
            return new List<string>();
        }
    }
}
