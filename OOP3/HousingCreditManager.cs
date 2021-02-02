using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing credit paying plan calculated.");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
