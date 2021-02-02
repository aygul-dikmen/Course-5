using System;
using System.Collections.Generic;

namespace OOP3
{    
    class Program
    {
        static void Main(string[] args)
        {
            NeedingCreditManager needingCreditManager = new NeedingCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            HousingCreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            DemandManager demandManager = new DemandManager();

            demandManager.Demand(needingCreditManager, fileloggerService);
             
            List<ICreditManager> krediler = new List<ICreditManager>() { };



        }
    }
}
