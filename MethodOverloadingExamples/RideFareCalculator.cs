using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    //3. Ride Fare Calculation(Uber-like System)
    //Scenario: A ride-booking app calculates fares differently based on ride type.
    //•	Overload CalculateFare() to: 
    //1.	Calculate fare for a regular ride
    //2.	Calculate fare for a premium ride with a multiplier
    //3.	Calculate fare for a shared ride with multiple passengers

    class RideFareCalculator
    {
        private const double BASE_RATE = 10.0; 
        private const double PREMIUM_MULTIPLIER = 1.5; 
        private const double SHARED_DISCOUNT = 0.2; 

        public double CalculateFare(double distanceInKm)
        {
            double fare = distanceInKm * BASE_RATE;
            Console.WriteLine($"Regular Ride Fare: {fare:F2} rs");
            return fare;
        }
        public double CalculateFare(double distanceInKm, double multiplier)
        {
            double fare = distanceInKm * BASE_RATE * multiplier;
            Console.WriteLine($"Premium Ride Fare: {fare:F2} rs");
            return fare;
        }
        public double CalculateFare(double distanceInKm, int passengers)
        {
            if (passengers < 1)
                Console.WriteLine("Passengers must be at least 1.");
            double totalFare = distanceInKm * BASE_RATE;
            double discount = (passengers - 1) * SHARED_DISCOUNT * totalFare;
            double finalFare = totalFare - discount;

            Console.WriteLine($"Shared Ride Fare for {passengers} passengers: {finalFare:F2} rs");
            return finalFare;
        }
    }
}
