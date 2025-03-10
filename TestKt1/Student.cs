using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestKt1
{
    class Student
    {
        private string Name { get; set; }
        private DateTime DateOfBirth { get; set; }

        private Address address { get; set; }

        private string AreaOfInterest { get; set; }

        private string PhoneNumber { get; set; }

        public Student(string name, DateTime dateOfBirth, Address address, string areaOfInterest, string phoneNumber)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            this.address = address;
            AreaOfInterest = areaOfInterest;
            PhoneNumber = phoneNumber;
        }

        public double CalculateAge(DateTime DateOfBirth)
        {
            DateTime today = DateTime.Now;
            double totalDays = (today - DateOfBirth).TotalDays;
            return totalDays / 365.25;
        }

        public void StudentInfo()
        {
            Console.WriteLine("Student Details : ");
            Console.WriteLine("Name : " +Name);
            Console.WriteLine("Age : "+CalculateAge(DateOfBirth));
            Console.WriteLine("Address : "+ address.DisplayAddress());
            Console.WriteLine("Area of Interest : "+AreaOfInterest);
            Console.WriteLine("Phone Number : "+PhoneNumber);
        }
    }
}
