using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class Employee
    {
        public string EmpName { get; set; }

        public int EmpID { get; set; }

        public double Salary { get; set; }

        public string Designation { get; set; }

        public Employee(string empName, int empID, double salary, string designation)
        {
            this.EmpName = empName;
            this.EmpID = empID;
            this.Salary = salary;
            this.Designation = designation;
        }

        public virtual double getBonus( double salary)
        {
            return 50000;
        }
    }
}
