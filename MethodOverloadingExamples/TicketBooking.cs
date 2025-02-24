using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    class TicketBooking
    {
        internal void BookTicket(Passenger passenger, string destination)
        {
            Console.WriteLine($"{passenger.name}, Your ticket has been booked for {passenger.destination} in {passenger.classType} class");
        }

        internal void BookTicket(Passenger passenger, string destination,string classType)
        {
            Console.WriteLine($"{passenger.name}, Your ticket has been booked for {passenger.destination} in {classType} class");
        }

        internal void BookTicket(List<Passenger> passengers, string destination)
        {
            for(int i = 0; i < passengers.Count; i++)
            {
                Console.Write(passengers[i].name+", ");
            }
            Console.WriteLine($"Your tickets has been booked for {passengers[0].destination} in {passengers[0].classType} class");
        }
    }
}
