using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AttributesInCSharp
{
    //Does this method log execution time? ❌ No!
    //The[LogExecutionTime] attribute does nothing by itself.
    //We need Reflection to detect this attribute and take action.

    public class OrderService
    {
        [LogExecutionTime]  // Custom Attribute
        public void ProcessOrder(int orderId)
        {
            Console.WriteLine($"Processing order {orderId}...");
            System.Threading.Thread.Sleep(1000); // Simulate processing time
        }
    }

}
