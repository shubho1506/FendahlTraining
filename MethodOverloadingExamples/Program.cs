using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExamples
{
    class Program
    {
        //4. Customer Support Chatbot Response System
        //Scenario: A chatbot responds differently based on the type of query.
        //•	Overload RespondToQuery() to: 
        //1.	Respond to basic queries
        //2.	Respond to priority queries
        //3.	Respond to multi-language queries

        static void Main(string[] args)
        {
            //FlightTicketBookingSystem();
            //BankLoanInterestCalculator();
            //FareCalculator();
            CustomerSupportChatBot();
        }


        static void FlightTicketBookingSystem()
        {
            TicketBooking booking = new TicketBooking();

            while (true)
            {
                Console.WriteLine("Please select your Type :");
                Console.WriteLine("Press 1 to book individual Ticket ");
                Console.WriteLine("Press 2 to book multiple passenger Tickets ");
                Console.Write("Please enter choice : ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Write("Please enter name : ");
                        string name = Console.ReadLine();
                        Console.Write("Please enter destination : ");
                        string destination = Console.ReadLine();
                        Console.WriteLine("Please Note : The default class is Economy ");
                        Console.Write("Please enter class (Economy/Business) : ");
                        string classType = Console.ReadLine();
                        if(classType != null)
                        {
                            booking.BookTicket(new Passenger(name, destination, classType), destination,classType);
                        }
                        else
                        {
                            booking.BookTicket(new Passenger(name, destination), destination);
                        }
                            break;
                    case 2:
                        List<Passenger> passengers = new List<Passenger>();
                        Console.Write("Please enter number of passengers you wish to add : ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Please enter destination : ");
                        string destinations = Console.ReadLine();
                        for (int i = 0; i < number; i++)
                        {
                            Console.Write("Please enter name : ");
                            string names = Console.ReadLine();
                            Console.WriteLine("Please Note : The default class is Economy ");
                            Console.Write("Please enter class (Economy/Business) : ");
                            string classTypes = Console.ReadLine();
                            passengers.Add(new Passenger(names, destinations, classTypes));
                        }
                        booking.BookTicket(passengers,destinations);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !!!");
                        break;
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using our flight ticket booking system !!!");
                    break;
                }
            }
        }

        static void BankLoanInterestCalculator()
        {
            CalcInterest calcInterest = new CalcInterest();

            while (true)
            {
                Console.WriteLine("Please select your Type :");
                Console.WriteLine("Press 1 to apply for personal Loan ");
                Console.WriteLine("Press 2 to apply for Home Loan ");
                Console.WriteLine("Press 3 to apply for Custom Loan ");
                Console.Write("Please enter choice : ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Write("Please enter name : ");
                        string name = Console.ReadLine();
                        Console.Write("Please enter principle amount : ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter time : ");
                        double time = Convert.ToDouble(Console.ReadLine());
                        Random random = new Random();
                        calcInterest.CalculateInterest(new LoanAccount((long)(random.NextDouble() * 9_000_000_000L) + 1_000_000_000L,name,"Personal",amount),time);
                        break;
                    case 2:
                        Console.Write("Please enter name : ");
                        string name1 = Console.ReadLine();
                        Console.Write("Please enter principle amount : ");
                        double amount1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter time : ");
                        double time1 = Convert.ToDouble(Console.ReadLine());
                        Random random1 = new Random();
                        calcInterest.CalculateInterest(new LoanAccount((long)(random1.NextDouble() * 9_000_000_000L) + 1_000_000_000L,name1,"Home",amount1),5,time1);
                        break;
                    case 3:
                        Console.Write("Please enter name : ");
                        string name2 = Console.ReadLine();
                        Console.Write("Please enter principle amount : ");
                        double amount2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter custom interest rate :");
                        double rate = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Please enter time : ");
                        double time2 = Convert.ToDouble(Console.ReadLine());

                        Random random2 = new Random();
                        calcInterest.CalculateInterest(new LoanAccount((long)(random2.NextDouble() * 9_000_000_000L) + 1_000_000_000L, name2, "Custom", amount2),"custom",rate,time2);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !!!");
                        break;
                }

                Console.Write("\nDo you wish to continue? (Y/N): ");
                string response = Console.ReadLine().Trim().ToUpper();

                if (response != "Y")
                {
                    Console.WriteLine("Thank you for using our Bank Loan Interest Calculator  !!!");
                    break;
                }
            }
        }

        static void FareCalculator()
        {
            RideFareCalculator rideCalculator = new RideFareCalculator();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Ride Fare Calculator");
                Console.WriteLine("1. Regular Ride");
                Console.WriteLine("2. Premium Ride");
                Console.WriteLine("3. Shared Ride");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    continue;
                }

                double distance;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter distance (km): ");
                        distance = double.Parse(Console.ReadLine());
                        rideCalculator.CalculateFare(distance);
                        break;

                    case 2:
                        Console.Write("Enter distance (km): ");
                        distance = double.Parse(Console.ReadLine());
                        rideCalculator.CalculateFare(distance, 1.5);
                        break;

                    case 3:
                        Console.Write("Enter distance (km): ");
                        distance = double.Parse(Console.ReadLine());
                        Console.Write("Enter number of passengers: ");
                        int passengers = int.Parse(Console.ReadLine());
                        rideCalculator.CalculateFare(distance, passengers);
                        break;

                    case 4:
                        Console.WriteLine("Exiting... Thank you for using Ride Fare Calculator!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        static  void CustomerSupportChatBot()
        {
            ChatBot chatbot = new ChatBot();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nCustomer Support Chatbot ");
                Console.WriteLine("1. Basic Query");
                Console.WriteLine("2. Priority Query");
                Console.WriteLine("3. Multi-language Query");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter your query: ");
                        string query1 = Console.ReadLine();
                        chatbot.RespondToQuery(query1);
                        break;

                    case 2:
                        Console.Write("Enter your query: ");
                        string query2 = Console.ReadLine();
                        Console.Write("Enter priority level (High/Medium/Low): ");
                        string priority = Console.ReadLine();
                        chatbot.RespondToQuery(query2, priority);
                        break;

                    case 3:
                        Console.Write("Enter your query: ");
                        string query3 = Console.ReadLine();
                        Console.Write("Enter priority level (High/Medium/Low): ");
                        string priority3 = Console.ReadLine();
                        Console.Write("Enter language (English/Spanish/French/German): ");
                        string language = Console.ReadLine();
                        chatbot.RespondToQuery(query3, priority3, language);
                        break;

                    case 4:
                        Console.WriteLine("Exiting... Thank you for using the Customer Support Chatbot!");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
