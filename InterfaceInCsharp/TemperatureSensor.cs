using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCsharp
{
    class TemperatureSensor : IDevice
    {
        private string data;
        public void Connect()
        {
            Console.WriteLine("Tempreture sensor device is connected !!! ");
        }
        public string ReceiveData()
        {
            return "data received : " + data ;
        }
        public void SendData(string message)
        {
            data = message;
            Console.WriteLine($"data sent - {message}"); ;
        }
    }
}
