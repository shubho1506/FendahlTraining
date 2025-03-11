using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKt1
{
    //need to take entry form user of student(name,s=address,dob,phone number,area of interest) if
    //iterator is science then add in science and maths in maths division and else add in arts. 
    //3 user entry details
    //print all division entry
    //print years in main

    //stringbuilder and its functions
    //singleton factory bridge design pattern ddd
    //covariance and contravariance
    //wcf rpc pattern

    class Program
    {
        static void Main(string[] args)
        {
            Science science = new Science();
            Maths maths = new Maths();
            Arts arts = new Arts(); 

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter details for Student {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Street: ");
                string street = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("State: ");
                string state = Console.ReadLine();

                Console.Write("Country: ");
                string country = Console.ReadLine();

                Console.Write("Zip Code: ");
                string zipCode = Console.ReadLine();

                Console.Write("Date of Birth (yyyy-MM-dd): ");
                DateTime dob;
                while (!DateTime.TryParse(Console.ReadLine(), out dob))
                {
                    Console.Write("Invalid format! Enter again (yyyy-MM-dd): ");
                }

                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Area of Interest (Science/Maths/Arts): ");
                string interest = Console.ReadLine().Trim();


                if (interest.Equals("Science",StringComparison.OrdinalIgnoreCase))
                {
                    science.AddStudent((new Student(name, dob, new Address(street, city, state, country, zipCode), interest, phoneNumber)));
                }
                else if (interest.Equals("Maths", StringComparison.OrdinalIgnoreCase))
                {
                    maths.AddStudent(new Student(name, dob, new Address(street, city, state, country, zipCode), interest, phoneNumber));
                }
                else
                {
                    arts.AddStudent(new Student(name, dob, new Address(street, city, state, country, zipCode), interest, phoneNumber));
                }
            }


            Console.WriteLine("\n--- Science Division ---");
            science.ShowStudents();
            Console.WriteLine("\n--- Maths Division ---");
            maths.ShowStudents();
            Console.WriteLine("\n--- Arts Division ---");
            arts.ShowStudents();
        }
    }
}
