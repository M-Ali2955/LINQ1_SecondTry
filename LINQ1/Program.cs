using System;
using System.Linq;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = CustomerData.Customers;

            foreach (var customer in customers)
            {
                DisplayCustomerInfo(customer);
            }

            DisplayAllCustomersInfo();

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }

        static void DisplayCustomerInfo(Customer customer)
        {
            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Total Orders: {customer.OrderTotal:C}");
            Console.WriteLine($"Backordered Quantity: {customer.BackOrdered}");

            if (customer.SalesOrders.Count > 0)
            {
                var avgOrderSize = customer.SalesOrders.Average(order => order.OrderTotal);
                Console.WriteLine($"Average Order Size: {avgOrderSize:C}");
            }
            else
            {
                Console.WriteLine("No Sales Orders");
            }

            Console.WriteLine(new string('-', 40));
        }

        static void DisplayAllCustomersInfo()
        {
            var allCustomers = CustomerData.Customers;
            var allOrders = allCustomers.SelectMany(c => c.SalesOrders).ToList();

            Console.WriteLine("\nSUMMARY FOR ALL CUSTOMERS");
            Console.WriteLine(new string('=', 40));

            if (allOrders.Count > 0)
            {
                var trueAverageOrderSize = allOrders.Average(order => order.OrderTotal);
                Console.WriteLine($"True Average Order Size: {trueAverageOrderSize:C}");
            }
            else
            {
                Console.WriteLine("No orders to calculate average.");
            }

            var topCustomer = allCustomers.OrderByDescending(c => c.OrderTotal).FirstOrDefault();
            if (topCustomer != null)
            {
                Console.WriteLine($"Top Customer by Order Total: {topCustomer.Name} ({topCustomer.OrderTotal:C})");
            }
        }
    }
}

