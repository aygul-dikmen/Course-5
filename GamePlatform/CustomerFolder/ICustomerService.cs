using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatform.CustomerFolder
{
    public interface ICustomerService
    {
        void SaveCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}
