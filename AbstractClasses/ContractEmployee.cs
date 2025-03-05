using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class ContractEmployee : Employee
    {
        public ContractEmployee(string empName, string empId, string empType) : base(empName, empId, empType)
        {
        }

        public override void CalculateSalary(int? hours)
        {
            Console.WriteLine($"Your salary will be {250*hours} rs.");
        }
    }
}
