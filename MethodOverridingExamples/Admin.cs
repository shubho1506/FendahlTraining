using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class Admin : Employee
    {
        public Admin(string empName, int empID, double salary, string designation) : base(empName, empID, salary, designation)
        {
        }

        //public override double getBonus( double salary)
        //{
        //    return base.getBonus(salary);
        //}
    }
}
