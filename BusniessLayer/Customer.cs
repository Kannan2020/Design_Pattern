using InterfaceCustomer;
using System;

namespace BusniessLayer
{
    public class Customer : CustomerBase
    {
        public Customer(IValidation<ICustomer> obj):base(obj)
        {

        }
    }
}
