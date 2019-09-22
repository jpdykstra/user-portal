using JPD.Demo.Service.Common.Enums;
using JPD.Demo.Service.Interfaces;
using System;

namespace JPD.Demo.Service.Seed.Factories
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
