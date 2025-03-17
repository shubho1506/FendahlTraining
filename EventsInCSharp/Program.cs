using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EventsInCSharp
{
    //An event in C# is a mechanism that enables a class to notify other classes or objects when something of interest happens. 
    //Events are based on delegates and are commonly used in GUI applications, 
    //asynchronous programming, and event-driven architectures.

    //Key Concepts
    //Publisher(Event Source) : The class that defines and raises an event.
    //Subscriber (Event Listener): The class that listens to and handles the event.
    //Delegate: Defines the signature of the event handler method.
    //Event: A special kind of delegate that only the declaring class can invoke, but other classes can subscribe to.

    public delegate void NotifyEventHandler(string message);

    class EventPublisher
    {
        // Declaring an event
        public event NotifyEventHandler Notify;

        public void TriggerEvent()
        {
            // Raising the event
            Console.WriteLine("Publisher: Raising event...");
            Notify?.Invoke("Event triggered!");
        }
    }

    class EventSubscriber
    {
        public void OnEventReceived(string message)
        {
            Console.WriteLine("Subscriber received: " + message);
        }
    }

    class EventSubscriber2
    {
        public void AnotherHandler(string message)
        {
            Console.WriteLine("Another handler: " + message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //EventImplementation();

            //TempretureHandler();

            BankBalanceChecker();
        }

        static void EventImplementation()
        {
            EventPublisher publisher = new EventPublisher();
            EventSubscriber subscriber1 = new EventSubscriber();
            EventSubscriber2 subscriber2 = new EventSubscriber2();

            // Multiple subscribers
            publisher.Notify += subscriber1.OnEventReceived;
            publisher.Notify += subscriber2.AnotherHandler;

            // Triggering the event
            publisher.TriggerEvent();
        }

        static void TempretureHandler()
        {
            TempretureSensor tempretureSensor = new TempretureSensor();
            tempretureSensor.TemperatureExceeded += TemperetureChecker.TempWarning;

            tempretureSensor.CheckTemperature(45);
        }

        static void BankBalanceChecker()
        {
            BankAccount account = new BankAccount(5000); 

            account.OnBalanceExceeded += 
                message => Console.WriteLine("!!! Notification: " + message);

            account.Withdraw(2000); 
            account.Withdraw(4000); 
        }
    }
}
