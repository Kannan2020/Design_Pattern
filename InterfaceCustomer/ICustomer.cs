using System;

namespace InterfaceCustomer
{
    public interface ICustomer
    {
        string CustomerName { get; set; }
        string PhoneNumber { get; set; }
        decimal Amount { get; set; }
        DateTime BillDate { get; set; }
        string Address { get; set; }
        void Validate();
    }
}
