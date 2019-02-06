using BusniessLayer;
using InterfaceCustomer;
using System;
using System.Collections.Generic;
using Unity;
using Unity.Injection;
using ValidationAlgorithms;

namespace Factory
{
    //Design Pattern:- Simple factory pattern automated using Unity
    public static class CustomerFactoryUsingUnity
    {
        private static IUnityContainer custs = null;
        static CustomerFactoryUsingUnity()
        {
            if(custs==null)
            {
                custs = new UnityContainer();
                custs.RegisterSingleton<ICustomer, Customer>("Customer",
                    new InjectionConstructor(new CustomerValidation())
                    );
                custs.RegisterSingleton<ICustomer, Lead>("Lead",
                    new InjectionConstructor(new LeadValidation()));
            }
        }
        public static ICustomer CreateObject(string custType)
        {
            return custs.Resolve<ICustomer>(custType);
        }
    }
}
