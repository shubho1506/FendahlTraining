using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PolymorphismInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCalculator();
            //AreaCalculator();
            //EmployeeObjectCreation();
            //BookObjectCreation();
            CoffeeMachine();
        }
        static void CoffeeMachine()
        {
            Coffee coffeeMachine = new Coffee();

            while (true)
            {
                Console.WriteLine("Please select your coffee:");
                Console.WriteLine("1. Filter");
                Console.WriteLine("2. French Press Coffee/Aero Press ");
                Console.Write("Enter choice (name or number): ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int choice))
                {
                    coffeeMachine.SelectCoffee(choice);
                }
                else
                {
                    coffeeMachine.SelectCoffee(userInput);
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using Coffee Machine !!!");
                    break;
                }
            }
        }

        static void BookObjectCreation()
        {
            Book book1 = new Book("The Alchemist");
            Book book2 = new Book("1984", "George Orwell");
            Book book3 = new Book("Indian Polity", "M.Laxmikant", 400.99);
            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
        }

        static void EmployeeObjectCreation()
        {
            Employee emp1 = new Employee();
            Console.WriteLine(emp1.DisplayDetails());
            Employee emp2 = new Employee("Shubhodeep Sarkar");
            Console.WriteLine(emp2.DisplayDetails());
            Employee emp3 = new Employee("Shubhodeep Sarkar",23);
            Console.WriteLine(emp3.DisplayDetails());

        }
        
        static void AreaCalculator()
        {
            AreaCalculator ac = new AreaCalculator();
            while (true)
            {
                Console.WriteLine("\n--- Area Calculation for Shapes ---");
                Console.WriteLine("Press 1 to the area of a circle");
                Console.WriteLine("Press 2 to the area of a rectangle");
                Console.WriteLine("Press 3 to the area of a triangle");
                Console.Write("Please enter your choice: ");

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Please enter the radius of the circle : ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the circle is : " + ac.CalcArea(radius));
                        break;
                    case 2:
                        Console.Write("Please enter the length of the rectangle : ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter the breadth of the rectangle : ");
                        double breadth = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the circle is : " + ac.CalcArea(length,breadth));
                        break;
                    case 3:
                        Console.Write("Please enter the base of the circle : ");
                        double basee = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter the height of the circle : ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Area of the circle is : " + ac.CalcArea(basee,height,0.5));
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please enter a number between 1-4.");
                        break;
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using Area Calculation!");
                    break;
                }
            }
        }

        static void AddCalculator()
        {
            Console.WriteLine("Calculator with Multiple Add Methods");
            AddCalculator ac = new AddCalculator();
            Console.Write("Please enter the value of A : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the value of B : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The output is : " + ac.add(a, b));
            Console.ReadLine();

            Console.Write("Please enter the value of A : ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the value of B : ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter the value of C : ");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The output is : " + ac.add(A, B, C));
            Console.ReadLine();

            Console.Write("Please enter the number of values you wish to add in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the values of array : ");
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Please enter values {i + 1} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The output is : " + ac.add(arr));
            Console.ReadLine();
        }
    }
}
