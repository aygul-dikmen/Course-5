using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.ID = 1;
            customer1.CustomerNumber = "13232";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.TCNo = "1234567790";

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.ID = 2;
            customer2.CustomerNumber = "234234";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1345676543";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            



        }
    }
}
