using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Intern : Employee
    {
        public int Duration { get; set; } 

        public Intern(string name, int id, double salary, int duration)
            : base(name, id, salary)
        {
            Duration = duration;
        }

        public void LearnSkills()
        {
            Console.WriteLine($"{Name} is learning new skills for {Duration} months.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Role: Intern, Duration: {Duration} months");
        }
    }
}
