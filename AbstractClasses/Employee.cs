using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Scenario 1: Employee Payroll System
    //A company has full-time employees and contract-based employees.The salary structure is different for each:
    //Full-time employees get a fixed monthly salary.
    //Contract - based employees are paid on an hourly basis.
    //Question:
    //Define an abstract class Employee with an abstract method CalculateSalary(). 
    //Implement FullTimeEmployee and ContractEmployee classes that provide their own salary calculation logic.
    abstract class Employee
    {
        internal string EmpName;
        internal string EmpId;
        internal string EmpType;

        public Employee(string empName, string empId, string empType)
        {
            EmpName = empName;
            EmpId = empId;
            EmpType = empType;
        }

        public abstract void CalculateSalary(int? hours);
    }
}
