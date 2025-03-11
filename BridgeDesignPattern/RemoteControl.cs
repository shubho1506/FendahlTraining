using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public virtual void PowerButton()
        {
            Console.WriteLine("Remote Control toggling power...");
            device.TurnOn();
            device.TurnOff();
        }
    }
}
