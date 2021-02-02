using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DemandManager
    {
        //Method injection
        public void Demand(ICreditManager creditManager, ILoggerService loggerService)
        {
            creditManager.Calculate();
            loggerService.Log();
        }
        public void CreditPreInformation(List<ICreditManager> krediler)
        {
            foreach(var credit in krediler)
            {
                credit.Calculate();
            }
        }
    }
}
