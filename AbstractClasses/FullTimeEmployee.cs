using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string empName, string empId, string empType) : base(empName, empId, empType)
        {
        }

        public override void CalculateSalary(int? hours)
        {
            Console.WriteLine("Your salary will be 50000 rs. ");
        }
    }
}
