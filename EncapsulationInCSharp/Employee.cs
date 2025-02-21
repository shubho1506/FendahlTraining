using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EncapsulationInCSharp
{

    //Problem 2: Employee Management System
    //Design an Employee class that encapsulates employee details such as name, employeeId, salary, and designation.
    //•	Requirements:
    //o All fields should be private, with public getters and setters for name and designation.
    //o Ensure that the salary field can only be modified internally via a method called UpdateSalary(decimal newSalary).
    //o Add a validation to prevent the salary from being set to a negative value.
    //o Include a method DisplayDetails() that shows all employee information.

    internal class Employee
    {
        private string name { get; set; }
        private int employeeId;
        private decimal salary;
        private string designation { get; set; }

        public Employee(string name, int empId, decimal salary, string dsgn)
        {
            this.name = name;
            this.employeeId = empId;
            this.designation = dsgn;
            this.salary = salary;
        }

        private void updateSalary(decimal newSalary)
        {
            if (newSalary < 0)
                Console.WriteLine("Salary cannot be negative.");
            else
            {
                this.salary = newSalary;
                Console.WriteLine("Salary updated.");
            }
                
        }

        public void updateSalaryEmp(decimal newSalary)
        {
            updateSalary(newSalary);
        }

        public string DisplayDetails()
        {
            return "Employee Details : \n" +
                "Name : " + name +
                " Id : " + employeeId +
                " Designation : " + designation +
                " Salary : " + salary;
        }
    }
}
