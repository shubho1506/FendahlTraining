using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_LINQ
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string department, double salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
}
