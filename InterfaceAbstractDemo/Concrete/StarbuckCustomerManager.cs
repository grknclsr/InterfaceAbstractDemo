﻿using InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbuckCustomerManager : BaseCustomerManger
    {
        private ICustomerCheckService _customerCheckService;
        public StarbuckCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }


        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
            
            
        }


    }
}
