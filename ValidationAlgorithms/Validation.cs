using InterfaceCustomer;
using System;

namespace ValidationAlgorithms
{
    public class CustomerValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (string.IsNullOrEmpty(obj.CustomerName))
                throw new Exception("Customer Name is required");
            if (string.IsNullOrEmpty(obj.PhoneNumber))
                throw new Exception("Phone Number is required");
            if (obj.BillDate > DateTime.Now)
                throw new Exception("Bill Date is required");
            if (obj.Amount <= 0)
                throw new Exception("Bill Amount is required");
            if (string.IsNullOrEmpty(obj.Address))
                throw new Exception("Address is required");
        }
    }
    public class LeadValidation : IValidation<ICustomer>
    {
        public void Validate(ICustomer obj)
        {
            if (string.IsNullOrEmpty(obj.CustomerName))
                throw new Exception("Customer Name is required");
            if (string.IsNullOrEmpty(obj.PhoneNumber))
                throw new Exception("Phone Number is required");
        }
    }
}
