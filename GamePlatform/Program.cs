using System;
using GamePlatform.CampaignFolder;
using GamePlatform.CheckIfRealFolder;
using GamePlatform.CustomerFolder;
using GamePlatform.GameFolder;
using GamePlatform.Sales;

namespace GamePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { CustomerID = 1, FirstName = "FirstName", LastName = "LatName", DateOfBirth = new DateTime(1999, 1, 1), NationalityID = "4567891232" };
            CustomerManager cm = new CustomerManager();
            cm.SaveCustomer(customer);
        }
    }
}
