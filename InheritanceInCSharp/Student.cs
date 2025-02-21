using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceInCSharp
{
    class Student : Person
    {
        string Grade { get; set; }

        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {base.Name}, Age: {base.Age}, Grade: {Grade}");
        }
    }
}
