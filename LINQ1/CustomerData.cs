using System.Collections.Generic;

namespace LINQ1
{
    public static class CustomerData
    {
        public static List<Customer> Customers => new List<Customer>
        {
            new Customer
            {
                Name = "Skip Wythe",
                SalesOrders = new List<SalesOrder>
                {
                    new SalesOrder { OrderId = 1, OrderTotal = 1000, Quantity = 5, Shipped = 5 },
                    new SalesOrder { OrderId = 2, OrderTotal = 1200, Quantity = 3, Shipped = 3 },
                    new SalesOrder { OrderId = 3, OrderTotal = 1183, Quantity = 2, Shipped = 2 }
                }
            },
            new Customer
            {
                Name = "James River",
                SalesOrders = new List<SalesOrder>
                {
                    new SalesOrder { OrderId = 4, OrderTotal = 2200, Quantity = 4, Shipped = 2 },
                    new SalesOrder { OrderId = 5, OrderTotal = 2700, Quantity = 5, Shipped = 4 },
                    new SalesOrder { OrderId = 6, OrderTotal = 2814, Quantity = 6, Shipped = 5 }
                }
            },
            new Customer
            {
                Name = "Maggie Walker",
                SalesOrders = new List<SalesOrder>
                {
                    new SalesOrder { OrderId = 7, OrderTotal = 2980, Quantity = 6, Shipped = 3 },
                    new SalesOrder { OrderId = 8, OrderTotal = 2980, Quantity = 5, Shipped = 2 }
                }
            }
        };
    }
}
