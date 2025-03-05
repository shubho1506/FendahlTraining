using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInCsharp
{
    //2. Factory Pattern with Interfaces
    //Scenario: You need to create objects dynamically at runtime based on user selection(e.g., creating a Car or Bike object).
    //Question:
    //Define a IVehicle interface with StartEngine() and StopEngine().
    //Implement Car and Bike classes.
    //Use a Factory pattern to return objects dynamically based on user input.
    interface IVehicle
    {
        void StartEngine();
        void StopEngine();
    }
}
