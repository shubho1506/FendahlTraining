using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingInCSharp
{
    class Pacman : GamingConsole
    {
        public void Down()
        {
            Console.WriteLine("go Down ");
        }

        public void GameShow()
        {
            Console.WriteLine("--- Pacman --- ");
        }

        public void Left()
        {
            Console.WriteLine("go Left ");
        }

        public void Right()
        {
            Console.WriteLine("go Right ");
        }

        public void Up()
        {
            Console.WriteLine("go Up ");
        }
    }
}
