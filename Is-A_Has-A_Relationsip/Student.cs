using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    //2. Problem:
    //Design a student record management system for a school.
    //Each student should have a Name, RollNumber, and Address.
    //The address should be stored as a separate class with fields like Street, City, State, and PostalCode.
    //Solution Hint:
    //•	Create a Student class that has properties for Name, RollNumber, and an Address object.
    //•	Create an Address class with properties like Street, City, etc.
    //•	Establish a "Has-a" relationship by embedding the Address object within the Student class.

    class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public Address StudentAddress { get; set; }

        public Student(string name, int rollNumber, Address address)
        {
            Name = name;
            RollNumber = rollNumber;
            StudentAddress = address;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student: {Name}, Roll Number: {RollNumber}");
            StudentAddress.DisplayAddress(); 
        }
    }
}
