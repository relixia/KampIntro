using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Buğra";
            customer1.Surname = "Çayır";
            customer1.TcNo = "12345678910";


            //Kodlama.io
            CorperateCustomer customer2 = new CorperateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.FactoryName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            //Gerçek müşteri - Tüzel müşteri
            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorperateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
