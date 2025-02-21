using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    //4. Problem:
    //Create a human resource management system where employees are categorized into various types: Manager, Engineer, and Intern.
    //All types of employees share common properties like Name, EmployeeID, and Salary,
    //but they may have additional specific behaviors (e.g., Manager may have a ManageTeam() method). 
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            EmployeeID = id;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID}, Name: {Name}, Salary: {Salary}");
        }
    }
}
