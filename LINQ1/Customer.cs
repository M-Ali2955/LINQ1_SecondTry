using System.Collections.Generic;
using System.Linq;

namespace LINQ1
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Region { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public List<SalesOrder> SalesOrders { get; set; }

        public Customer()
        {
            SalesOrders = new List<SalesOrder>();
        }

        public double OrderTotal => SalesOrders.Sum(order => order.OrderTotal);

        public int BackOrdered => SalesOrders.Sum(order => order.Quantity - order.Shipped);
    }
}
