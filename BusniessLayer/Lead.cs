using InterfaceCustomer;

namespace BusniessLayer
{
    public class Lead : CustomerBase
    {
        public Lead(IValidation<ICustomer> obj) : base(obj)
        {

        }
    }
}
