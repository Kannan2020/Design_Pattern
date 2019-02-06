using InterfaceCustomer;
using System;

namespace BusniessLayer
{
    public class CustomerBase : ICustomer
    {
        private IValidation<ICustomer> validation = null;
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }
        public CustomerBase(IValidation<ICustomer> obj)
        {
            validation = obj;
        }
            public CustomerBase()
        {
            CustomerName = "";
            PhoneNumber = "";
            Amount = 0;
            BillDate = DateTime.Now;
            Address = "";
        }
        public virtual void Validate()
        {
            validation.Validate(this);
        }
    }
}
