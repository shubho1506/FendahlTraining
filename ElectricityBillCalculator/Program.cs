using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBillCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of units consumed : ");
            double units = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Total bill : "+ CalculateBill(units));
        }

        public static double CalculateBill(double units)
        {
            double bill = 0;

            if (units > 300)
            {
                bill += (units - 300) * 12;
                units = 300;
            }
            if (units > 200)
            {
                bill += (units - 200) * 6;
                units = 200;
            }
            if (units > 100)
            {
                bill += (units - 100) * 4;
                units = 100;
            }
            bill += units * 2;

            return bill;
        }
    }
}
