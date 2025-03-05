using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCsharp
{
    //1. IoT Device Communication
    //Scenario: You are building software for an IoT system where different devices(TemperatureSensor, MotionSensor, and LightController) communicate.
    //Question:
    //Define an IDevice interface with methods like Connect(), SendData(), and ReceiveData().
    //Implement it for TemperatureSensor and MotionSensor.
    interface IDevice
    {
        void Connect();
        void SendData(string message);
        string ReceiveData();
    }
}
