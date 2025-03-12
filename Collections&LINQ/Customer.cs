using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_LINQ
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string City { get; set; }
        public Customer(string customerName, string city)
        {
            CustomerName = customerName;
            City = city;
        }
    }
}
