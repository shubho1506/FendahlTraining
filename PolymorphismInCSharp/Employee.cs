using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInCSharp
{
    //3. Problem Statement: Employee Object Creation
    //Task: Create an Employee class with overloaded constructors to handle different initialization scenarios.
    //•	Requirement:
    //o A default constructor that initializes an employee with default values(e.g., "Unknown" for the name).
    //o A constructor that accepts only the employee's name.
    //o A constructor that accepts both the name and age of the employee.
    //•	Objective: Demonstrate flexibility in object creation with different levels of initialization.
    class Employee
    {
        string name;
        int? age;

        public Employee()
        {
            Console.WriteLine("Default constructor called ");
            this.name = "unknown";
        }

        public Employee(string name)
        {
            Console.WriteLine("constructor with employee's name called");
            this.name = name;
        }

        public Employee(string name, int? age)
        {
            Console.WriteLine("constructor with employee's name and age called");
            this.name = name;
            this.age = age;
        }

        public string DisplayDetails()
        {
            return "Employee Details \n" +
                " Name : " + this.name +
                " Age : " + this.age;
        }
    }
}
