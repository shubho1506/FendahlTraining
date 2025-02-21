using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Engineer : Employee
    {
        public string Specialization { get; set; }

        public Engineer(string name, int id, double salary, string specialization)
            : base(name, id, salary)
        {
            Specialization = specialization;
        }

        public void DevelopSoftware()
        {
            Console.WriteLine($"{Name} is developing software in {Specialization}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Engineer, Specialization: {Specialization}");
        }
    }
}
