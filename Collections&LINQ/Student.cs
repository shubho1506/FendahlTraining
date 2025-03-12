using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_LINQ
{
    class Student
    {
        public string Name { get; set; }
        public double Mark { get; set; }

        public Student(string names, double marks)
        {
            Name = names;
            Mark = marks;
        }
    }
}
