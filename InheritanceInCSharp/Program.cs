using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //PSR();
            //VHr();
            //ASn();
            //DBh();
            SACalc();
        }

        static void FIT()
        {
            //Person p1 = new Person();
            //Employee e1 = new Employee();
            //Employee e3 = new Employee("shubhodeep");
            //Employee e4 = new Employee("shubhodeep", "sarkar");
            //Console.WriteLine(e4.toStringD());
            //Person p2 = new Employee();
            //Employee e2 = new Person();
            //Person p1 = new Person();
            //Employee e1 = new Employee();
            //Employee e3 = new Employee("shubhodeep");
            //Employee e4 = new Employee("shubhodeep", "sarkar");
            //Console.WriteLine(e4.toStringD());
            //Person p2 = new Employee();
            //Employee e2 = new Person();
        }

        static void PSR()
        {
            Console.WriteLine("Problem 1: Person and Student Application");
            Person person1 = new Person("Jake", 20);
            person1.DisplayInfo();

            Student student1 = new Student("Jill", 10, "A+");
            student1.DisplayInfo();
            Console.ReadLine();
        }

        static void VHr()
        {
            Vehicle v1 = new Vehicle("Normal Vehicle", 80);
            v1.StartEngine();
            v1.DisplayInfo();

            Console.WriteLine();

            Car car1 = new Car("BMW", 120, 4);
            car1.StartEngine();
            car1.DisplayInfo();

            Console.WriteLine();

            ElectricCar eCar1 = new ElectricCar("Maruti BE6", 150, 4, 85);
            eCar1.StartEngine();
            eCar1.DisplayInfo();
            Console.ReadLine();

        }

        static void ASn()
        {
            Animal Animal = new Animal(" Animal");
            Dog dog = new Dog("Tommy");
            Cat cat = new Cat("Siya");

            Animal.Speak();
            dog.Speak();
            cat.Speak();
            Console.ReadLine();

        }

        static void DBh()
        {
            Duck goodDuck = new Duck("PsiDuck");
            goodDuck.ShowBehaviors();
            Console.ReadLine();

        }

        static void SACalc()
        {
            IShape rectangle = new Rectangle("Rectangle", 18, 90);
            IShape circle = new Circle("Circle", 26);

            rectangle.DisplayArea();
            circle.DisplayArea();
            Console.ReadLine();

        }
    }
}
