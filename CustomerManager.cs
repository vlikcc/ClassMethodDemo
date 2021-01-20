using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void SaveCustomer(Customer customer)
        {
            Console.WriteLine("Please Insert Customer Id: ");
            customer.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Insert Customer National Identity: ");
            customer.NationalIdentity = Console.ReadLine();
            Console.WriteLine("Please Insert Customer Account Number: ");
            customer.AccountNumber = Console.ReadLine();
            Console.WriteLine("Please Insert Customer First Name: ");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("Please Insert Customer Last Name: ");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("Please Insert Customer Mail Address: ");
            customer.MailAddress = Console.ReadLine();
            Console.WriteLine("Please Insert Customer Account Balance: ");
            customer.AccountBalance = Convert.ToDouble(Console.ReadLine());
            customers.Add(customer);
            Console.WriteLine("Customer Added to Customers List");
            Console.WriteLine("-----------------------------");



        }
        public void ListCustomer(Customer customer )
        {
            foreach (Customer customer1 in customers)
            {
                Console.WriteLine(customer1.Id);
                Console.WriteLine(customer1.NationalIdentity);
                Console.WriteLine(customer1.AccountNumber);
                Console.WriteLine(customer1.FirstName);
                Console.WriteLine(customer1.LastName);
                Console.WriteLine(customer1.MailAddress);
                Console.WriteLine(customer1.AccountBalance);
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Plaese Insert Customer Id for Deleting Customer From Customer List");
            int id = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < customers.Count; i++)
            {
                if (id ==customer.Id)
                {
                    customers.Remove(customer);
                }
            }   
                    

            Console.WriteLine("Customer Deleted From Customer List");
            
        }
        
    }
}
