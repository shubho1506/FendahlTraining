using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CouplingInCSharp
{
    //Coupling refers to the degree of dependency between different software components (classes, modules, or functions).
    //It measures how much one component relies on another to function correctly.

    //Coupling can be categorized into two main types:

    //Type Description Example
    //1. Tight Coupling(High Dependency) - When one component is highly dependent on another.
    //        A change in one class directly affects the other.
    //        A class directly creates an object of another class inside its methods.
    //2. Loose Coupling (Low Dependency) - When components are independent and communicate through interfaces or abstractions. 
    //        Changes in one class do not break the other.
    //        A class depends on an interface, not a specific implementation.
    class Program
    {

        // 1️. Engine Class (For Tight Coupling)
        class Engine
        {
            public void Start() => Console.WriteLine("Engine Started");
        }

        // 2️. Tightly Coupled Car (Bad Practice)
        class TightCoupledCar
        {
            private Engine engine = new Engine(); // 🚨 Direct dependency (Tight Coupling)

            public void StartCar() => engine.Start();
        }

        // 3️. Interface for Loose Coupling
        interface IEngine
        {
            void Start();
        }

        // 4️. Petrol Engine (Implements IEngine)
        class PetrolEngine : IEngine
        {
            public void Start() => Console.WriteLine("Petrol Engine Started");
        }

        // 5️. Electric Engine (Implements IEngine)
        class ElectricEngine : IEngine
        {
            public void Start() => Console.WriteLine("Electric Engine Started");
        }

        // 6️. Loosely Coupled Car (Good Practice)
        class LooseCoupledCar
        {
            private IEngine engine; //  Uses Interface instead of a direct class dependency

            public LooseCoupledCar(IEngine engine) // Constructor Injection (Dependency Injection)
            {
                this.engine = engine;
            }

            public void StartCar() => engine.Start();
        }

        static void Main(string[] args)
        {

            ////  Example of Tight Coupling
            //Console.WriteLine("Tightly Coupled Car:");
            //TightCoupledCar car1 = new TightCoupledCar();
            //car1.StartCar(); // Engine Started

            //Console.WriteLine("\nLoosely Coupled Car with Petrol Engine:");
            ////  Example of Loose Coupling with Petrol Engine
            //IEngine petrolEngine = new PetrolEngine();
            //LooseCoupledCar car2 = new LooseCoupledCar(petrolEngine);
            //car2.StartCar(); // Petrol Engine Started

            //Console.WriteLine("\nLoosely Coupled Car with Electric Engine:");
            ////  Example of Loose Coupling with Electric Engine
            //IEngine electricEngine = new ElectricEngine();
            //LooseCoupledCar car3 = new LooseCoupledCar(electricEngine);
            //car3.StartCar(); // Electric Engine Started

            game();

        }

        static void game()
        {
            GamingConsole gaming = new Mario();  //cd daalne wala function

            Ps5 ps5 = new Ps5(gaming);
            ps5.showGame();
            ps5.moveUp();
            ps5.moveDown();
            ps5.moveRight();
            ps5.moveLeft();

        }
    }
}
