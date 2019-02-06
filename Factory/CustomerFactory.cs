using BusniessLayer;
using InterfaceCustomer;
using System;
using System.Collections.Generic;

namespace Factory
{
    public static class CustomerFactory //Design Pattern:- Simple factory pattern
    {
        ////Design Pattern:- Lazy Loading
        //private static Lazy<Dictionary<string, CustomerBase>> custs = null; 
        //static CustomerFactory()
        //{
        //    custs= new Lazy<Dictionary<string, CustomerBase>>(()=>LoadClasses());
            
        //}
        //private static Dictionary<string, CustomerBase> LoadClasses()
        //{
        //    Dictionary<string, CustomerBase> temp = new Dictionary<string, CustomerBase>();
        //    temp.Add("customer", new Customer());
        //    temp.Add("lead", new Lead());
        //    return temp;
        //}
        //public static ICustomer CreateObject(string custType)
        //{
        //    // Design Pattern:- RIP (Replace If with Polymorphism)
        //    return custs.Value[custType.ToLowerInvariant()];
        //}
    }
}
