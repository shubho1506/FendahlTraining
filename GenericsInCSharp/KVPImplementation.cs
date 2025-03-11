using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    class KVPImplementation
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Key-Value Pair ---");
            Console.Write("Enter a key: ");
            string key = Console.ReadLine();
            Console.Write("Enter a value: ");
            string value = Console.ReadLine();

            KeyValuePairProblem<string, string> pair = new KeyValuePairProblem<string, string>(key, value);
            pair.Display();
        }
    }
}
