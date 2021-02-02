using System;
using System.Collections.Generic;
using System.Text;
using GamePlatform.CheckIfRealFolder;

namespace GamePlatform.CustomerFolder
{
    class CustomerManager : ICustomerService
    {
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" deleted successfully.");
        }

        public void SaveCustomer(Customer customer)
        {
            MernisServiceAdaptor msa = new MernisServiceAdaptor();
            if(msa.CheckIfRealPerson(customer)==true)
            {
                Console.WriteLine(customer.FirstName + " is real person.");
            }
            else
            {
                Console.WriteLine(customer.FirstName + " is not a real person.");
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" updated successfully.");
        }
    }
}
