using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManger customerManager = new StarbuckCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirthday = new DateTime(2000,02,16),FirstName="Gürkan",LastName="Çalışır",NationalityId = "01234567891"});
            Console.ReadLine();
        }
    }
}
