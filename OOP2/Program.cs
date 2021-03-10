using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual customer1 = new Individual();
            customer1.ID = 1;
            customer1.CustomerId = "12345";
            customer1.CustomerName = "Tuğçe";
            customer1.CustomerSurname = "Yazıcı";
            customer1.IdentityNumber = "12345678910";

            Coorporate customer2 = new Coorporate();
            customer2.ID = 2;
            customer2.CustomerId = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxId = "1234567890";

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            



        }
    }
}
