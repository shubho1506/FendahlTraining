using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingInCSharp
{
    class Mario : GamingConsole
    {
        public void Down()
        {
            Console.WriteLine("move down");
        }

        public void GameShow()
        {
            Console.WriteLine("--- Mario game ---");
        }

        public void Left()
        {
            Console.WriteLine("move Left");
        }

        public void Right()
        {
            Console.WriteLine("move Right");
        }

        public void Up()
        {
            Console.WriteLine("move Up");
        }
    }
}
