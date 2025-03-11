using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            IDevice projector = new Projector();

            RemoteControl basicRemote = new RemoteControl(tv);
            basicRemote.PowerButton();

            Console.WriteLine();

            AdvancedRemote advancedRemote = new AdvancedRemote(projector);
            advancedRemote.PowerButton();
            advancedRemote.Mute();
        }
    }
}
