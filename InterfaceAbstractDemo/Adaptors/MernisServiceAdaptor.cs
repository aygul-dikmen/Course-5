using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo.Adaptors
{
    public class MernisServiceAdaptor : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
      
            return Convert.ToBoolean(client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityID), customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year));
        }
    }
}
