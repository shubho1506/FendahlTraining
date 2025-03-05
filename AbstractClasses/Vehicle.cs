using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Scenario 2: Vehicle Rental System
    //A vehicle rental system allows customers to rent cars and bikes.Each vehicle has:
    //1. A method to calculate rental price based on the number of hours rented.
    //2. A method to display vehicle details.
    //Question:
    //Create an abstract class Vehicle with an abstract method CalculateRentalPrice(int hours).
    //Implement Car and Bike classes that provide their own pricing logic.
    abstract class Vehicle
    {
        internal string VehicleModel;
        internal string VehicleNumber;
        public Vehicle(string VehicleNumber, string VehicleModel)
        {
            this.VehicleNumber = VehicleNumber;
            this.VehicleModel = VehicleModel;
        }

        public void DisplayDetails(string vehicle,string Name)
        {
            Console.WriteLine($"Details of {vehicle} are : ");
            Console.WriteLine($"Vehicle Model : {this.VehicleModel}" );
            Console.WriteLine($"Vehicle Number : {this.VehicleNumber}");
            Console.WriteLine($"Vehicle assigned to  : {Name}");


        }
        public abstract void CalculateRentalPrice(int hours);
    }
}
