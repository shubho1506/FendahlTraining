using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Is_A_Has_A_Relationsip
{
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing a team of {TeamSize} employees.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Manager, Team Size: {TeamSize}");
        }
    }
}
