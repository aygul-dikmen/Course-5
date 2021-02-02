using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle credit paying plan calculated.");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
