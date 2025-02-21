using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    class InheritanceFendahlTraining
    {
        class Person
        {
            internal string name;
            internal Person()
            {

            }

            internal Person(string name)
            {
                this.name = name;
            }
        }

        class Employee : Person
        {
            string name;
            internal Employee()
            {

            }

            internal Employee(string name)
            {
                this.name = name;
            }

            internal Employee(string name, string Name) : base(Name)
            {
                this.name = name;
            }

            public string toStringD()
            {
                return "Emp : " + name +
                    " Person : " + base.name;
            }
        }
    }
}
