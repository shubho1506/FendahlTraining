using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceInCsharp
{


    interface I1
    {
        void Hello();
    }

    interface I2
    {
        void Hello();
    }

    class HelloWorld : I1, I2
    {
        public void Hello()
        {
            Console.WriteLine("Hello class");
        }

        void I1.Hello()
        {
            Console.WriteLine("Hello I1");

        }

        void I2.Hello()
        {
            Console.WriteLine("Hello I2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceImplementation();
            //LoggerSystem();
            //IOTDeviceSystem();
            VehicleObjectCreation();

        }

        static void InterfaceImplementation()
        {
            InterfaceImplementation inf = new InterfaceImplementation();
            inf.SayHello();
            IClassHello ih = new InterfaceImplementation();
            ih.SayHello();
            ih.ExplicitHello();

            HelloWorld hw = new HelloWorld();
            hw.Hello();
            I1 obj1 = new HelloWorld();
            obj1.Hello();
            I2 obj2 = new HelloWorld();
            obj2.Hello();
        }

        static void LoggerSystem()
        {
            string logFilePath = "application.log";

            ILogger log1 = new ConsoleLogger(logFilePath);
            log1.LogInfo("log information");
            log1.LogWarning("log warning");
            log1.LogError("log error");

            ILogger log2 = new FileLogger(logFilePath);
            log2.LogInfo("log information");
            log2.LogWarning("log warning");
            log2.LogError("log error");

            ILogger log3 = new CloudLogger(logFilePath);
            log3.LogInfo("log information");
            log3.LogWarning("log warning");
            log3.LogError("log error");
        }

        static void IOTDeviceSystem()
        {
            IDevice device;
             device = new TemperatureSensor();
            device.Connect();
            device.SendData("25°C");
            Console.WriteLine("Received: " + device.ReceiveData());

            device = new MotionSensor();
            device.Connect();
            device.SendData("Motion detected");
            Console.WriteLine("Received: " + device.ReceiveData());

            device = new LightController();
            device.Connect();
            device.SendData("Light detected");
            Console.WriteLine("Received: " + device.ReceiveData());
        }

        static void VehicleObjectCreation()
        {
            Console.Write("Enter vehicle type (Car/Bike): ");
            string input = Console.ReadLine();
            try
            {
                IVehicle vehicle = VehicleFactory.GetVehicle(input);
                vehicle.StartEngine();
                vehicle.StopEngine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
