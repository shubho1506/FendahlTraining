using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    //1. Flight Booking System
    //Scenario: A flight booking system allows users to book tickets with different options.
    //•	Overload the BookTicket() method to handle: 
    //1.	Booking with passenger name and destination
    //2.	Booking with passenger name, destination, and class type(Economy/Business)
    //3.	Booking with multiple passengers
    class Passenger
    {
        internal string name { get; set; }
        internal string destination { get; set; }
        internal string classType { get; set; }

        public Passenger(string name, string destination, string classType = "Economy")
        {
            this.name = name;
            this.destination = destination;
            this.classType = classType;
        }
    }
}
