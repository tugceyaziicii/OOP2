using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalLoanCreditManager = new PersonalLoanCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager vehicleLoanManager= new VehicleLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.BasvuruYap(personalLoanCreditManager,new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>() {personalLoanCreditManager,vehicleLoanManager };
          //  applicationManager.KrediOnBilgilendirmesiYap(credits);

        }
    }
}
