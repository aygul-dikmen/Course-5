using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Needing credit paying plan calculated.");
        }

        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
