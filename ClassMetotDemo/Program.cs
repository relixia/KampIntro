using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 11111;
            customer1.Name = "Buğra";
            customer1.Surname = "Çayır";
            customer1.Age = 17;
            customer1.Job = "Student";

            Customer customer2 = new Customer();
            customer2.ID = 22222;
            customer2.Name = "Feride";
            customer2.Surname = "Kaya";
            customer2.Age = 21;
            customer2.Job = "Doctor";

            Customer customer3 = new Customer();
            customer3.ID = 33333;
            customer3.Name = "Ahmet";
            customer3.Surname = "Zor";
            customer3.Age = 35;
            customer3.Job = "Engineer";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("---------------------------Add Customer------------------------------");
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            Console.WriteLine("---------------------------Delete Customer------------------------------");
            customerManager.DeleteCustomer(customer3);
            Console.WriteLine("--------------------Please press enter to see the whole customer list-----------------");
            Console.ReadKey();
            customerManager.ListCustomers(customers);

        }
    }
}
