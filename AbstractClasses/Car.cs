using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Car : Vehicle
    {
        public Car(string VehicleNumber,string VehicleModel) : base(VehicleNumber,VehicleModel)
        {
        }


        public override void CalculateRentalPrice(int hours)
        {
            double RentPricePerHour = 20;
            Console.WriteLine($"The price to rent {this.VehicleModel} will be {RentPricePerHour*hours} rs.");
        }
    }
}
