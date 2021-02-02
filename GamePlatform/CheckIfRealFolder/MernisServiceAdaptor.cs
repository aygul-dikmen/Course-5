using GamePlatform.CustomerFolder;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace GamePlatform.CheckIfRealFolder
{
    public class MernisServiceAdaptor: ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityID), customer.FirstName, customer.LastName, customer.DateOfBirth.Year).Result;
            return result.Body.TCKimlikNoDogrulaResult;
            //return Convert.ToBoolean(client.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityID), customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year));
        }
    }
}
