using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class Manager : Employee
    {
        public Manager(string empName, int empID, double salary, string designation) : base(empName, empID, salary, designation)
        {
        }

        public override double getBonus(double salary)
        {
            return 50000 > (salary *0.25) ? 50000 : (salary *0.25);
        }
    }
}
