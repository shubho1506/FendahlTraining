using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FendahlTraining
{

    class Employee
    {
        private string name;
        private int empId;

        public Employee(string name, int empId)
        {
            this.name = name;
            this.empId = empId;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public double getEmpId()
        {
            return empId;
        }

        public void setEmpId(int empId)
        {
            this.empId = empId;
        }
    }
}
