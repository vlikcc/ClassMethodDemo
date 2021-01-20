using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.SaveCustomer(customer);
            customerManager.ListCustomer(customer);
            customerManager.DeleteCustomer(customer);
        }
    }
}
