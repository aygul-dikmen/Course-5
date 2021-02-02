using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adaptors;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { DateOfBirth = new DateTime(1999, 1, 1), FirstName = "Aygül", LastName = "Dikmen", NationalityID = "16735198516" };
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdaptor());
            customerManager.Save(customer);
            Console.ReadLine();
            


        }
    }

}
