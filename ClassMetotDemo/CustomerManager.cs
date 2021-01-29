using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " added to the system. Welcome!");
            
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + customer.Surname + " deleted from the system. Thanks for your participation!");
        }

        public void ListCustomers(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.ID);
                Console.WriteLine("Customer name and surname: " + customer.Name + " " + customer.Surname);
                Console.WriteLine("Customer age: " + customer.Age);
                Console.WriteLine("Customer job: " + customer.Job);
                Console.WriteLine("----------------------------------------------------------------");


            }
        }
    }
}
