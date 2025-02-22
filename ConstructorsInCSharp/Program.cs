using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsInCSharp
{
    class Program
    {
        //Default Constructor - Initializes an object with default values.
        //Parameterized Constructor -  Accepts parameters to initialize fields with custom values.
        //Copy Constructor  - Creates a new object by copying an existing object.
        //Static Constructor - Used to initialize static members, called only once per class.
        //Private Constructor - Prevents object creation from outside the class (used in Singleton Pattern).

        //Default Constructor
        public Program()
        {
            Console.WriteLine("This is default constructor ");
        }

        //Parameterized Constructor
        string say;
        public Program(string sayHello)
        {
            this.say = sayHello;
            Console.WriteLine(say);
        }


        //Static Constructor
        static int initialValue;
        static Program()
        {
            Console.WriteLine("Static Constructor Called");
            initialValue = 500; 
        }


        //Copy Constructor
        class Car
        {
            public string Brand;
            public int Year;

            // Parameterized Constructor
            public Car(string brand, int year)
            {
                Brand = brand;
                Year = year;
            }

            // Copy Constructor
            public Car(Car existingCar)
            {
                Brand = existingCar.Brand;
                Year = existingCar.Year;
            }

            public void Display()
            {
                Console.WriteLine($"Car: {Brand}, Year: {Year}");
            }
        }

        static void Main(string[] args)
        {
            //Default Constructor
            Program p = new Program();

            //Parameterized Constructor
            Program p1 = new Program("This is parametrized constructor");

            //Static Constructor
            Console.WriteLine(Program.initialValue);

            // Copy Constructor
            Car car1 = new Car("Honda", 2023);
            Car car2 = new Car(car1); 
            car1.Display();  
            car2.Display();
        }
    }
    }
