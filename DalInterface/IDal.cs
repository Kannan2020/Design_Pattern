using System;
using System.Collections.Generic;
using System.Text;

namespace DalInterface
{
    //Design Pattern:- Repository pattern
    //Design Pattern:- Generic Repository pattern
    public interface IDal<AnyType>
    {
        void Add(AnyType obj);//In memory  Allowcation
        void Update(AnyType obj);//In memory  Allowcation
        List<AnyType> Search();
        void Save();// Physical Commit
    }
}
