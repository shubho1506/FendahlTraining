using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Projector : IDevice
    {
        public void TurnOn() => Console.WriteLine("Projector is ON");
        public void TurnOff() => Console.WriteLine("Projector is OFF");
    }
}
