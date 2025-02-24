using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInCSharp
{
    class Coffee
    {
        public void SelectCoffee(string name)
        {
            Console.WriteLine($"{name} Coffee is getting prepared !!! ");
        }

        public void SelectCoffee(int number)
        {
            switch (number)
            {
                case 1:
                    SelectCoffee("Filter");
                    break;
                case 2:
                    SelectCoffee("French Press/Aero Press");
                    break;
                default:
                    Console.WriteLine(" Invalid selection!!! Please choose from the given options !!!");
                    break;
            }
        }
    }
}
