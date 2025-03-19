using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeKT1
{
    class InventoryResponses
    {
        public void LowStocksWarning(string message)
        {
            Console.WriteLine($"This product need restocking - {message}");
        }
    } 
}
