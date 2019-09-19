using JPD.Demo.Service.Business;
using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JPD.Demo.Service.Common
{
    public static class AddressSeedFactory
    {
        public static IAddressSeed Create(AddressType addressType)
        {
            switch (addressType)
            {
                case AddressType.Unknown:
                    throw new ArgumentException("Invalid address type - Unknown.", "addressType");

                case AddressType.Mailing:
                    return new MailingAddressSeedLogic();
                    
                case AddressType.Billing:
                    return new BillingAddressSeedLogic();
                    
                default:
                    return new MailingAddressSeedLogic();
            }
        }
    }
}
