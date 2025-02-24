using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceProductPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prodList = new List<Product>();
            prodList.Add(new Product("T-shirt"));
            prodList.Add(new Product("iphone", "B"));
            prodList.Add(new Product("Air Conditioner", "C"));

            CalcPrice calcPrice = new CalcPrice();

            while (true)
            {
                Console.WriteLine("Please select your product :");
                Console.WriteLine("1. T-shirt");
                Console.WriteLine("2. iphone ");
                Console.WriteLine("3. Air Conditioner ");
                Console.Write("Enter choice (name or number): ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        calcPrice.CalculatePrice(prodList[0], 500);
                        break;
                    case 2:
                        calcPrice.CalculatePrice(prodList[1], 100000, prodList[1].productCategory);
                        break;
                    case 3:
                        calcPrice.CalculatePrice(prodList[2], 35000, prodList[2].productCategory, 30);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !!!");
                        break;
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using our site !!!");
                    break;
                }
            }
        }
    }
}
