using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonalManager customerManager = new CustomerManager();
            customerManager.Add();
        
        }
    }
    interface IPersonalManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonalManager
    {
        public void Add()
        {
            //Musteri ekleme kodları
            Console.WriteLine("Customer added.");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class EmployeeManager : IPersonalManager
    {
        public void Add()
        {
            Console.WriteLine("Employee added.");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class ProjectManager
    {
        public void Add(IPersonalManager personalManager)
        {
            personalManager.Add(); //Yeni bir class eklenirse de çalışır.
        }
    }
}
