using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManger : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db :  "+customer.FirstName);
        }
    }
}
