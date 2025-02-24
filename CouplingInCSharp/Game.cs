using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouplingInCSharp
{
    class Ps5
    {


        GamingConsole game;
        public Ps5(GamingConsole game)
        {
            this.game = game;
        }

        public void moveUp()
        {
            game.Up();
        }

        public void moveDown()
        {
            game.Down();
        }

        public void moveLeft()
        {
            game.Left();
        }

        public void moveRight()
        {
            game.Right();
        }

        public void showGame()
        {
            game.GameShow();
        }
    }
}
