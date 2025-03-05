using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{

    class Program
    {
        abstract class AbstractClass
        {
            public abstract void SayHello();
            public void Abstract()
            {
                Console.WriteLine("This method is in abstract class ");
            }
        }

        class AbstractClassInherit : AbstractClass
        {
            public override void SayHello()
            {
                Console.WriteLine("Hello, This method is in AbstractClassInherit class");
            }
        }
        static void Main(string[] args)
        {
            //AbstractExamples()
            //PaymentProcessing();
            //NotificationSystem();
            //VehicleRentalSystem();
            //EmployeePayrollSystem();
            OnlineDiscountSystem();
        }

        static void AbstractExamples()
        {
            AbstractClassInherit abs = new AbstractClassInherit();
            abs.Abstract();
            abs.SayHello();
        }

        static void PaymentProcessing()
        {
            Payment payment;
            Console.Write("Please enter your amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your payment method (Credit card/Paypal/BankTransfer) : ");
            string method = Console.ReadLine();
            if (method.Equals("Credit card"))
            {
                payment = new CreditCardPayment();
                payment.ProcessPayment(amount);
            }
            else if (method.Equals("Paypal"))
            {
                payment = new PayPalPayment();
                payment.ProcessPayment(amount);
            }
            else
            {
                payment = new BankTransferPayment();
                payment.ProcessPayment(amount);
            }
        }

        static void NotificationSystem()
        {
            Notification notify;
            Console.Write("Please enter your message : ");
            string message = Console.ReadLine();
            Console.Write("How you wish to send your notification (Email/SMS/Push) : ");
            string method = Console.ReadLine();
            if (method.Equals("Email"))
            {
                notify = new EmailNotification();
                notify.SendNotification(message);
            }
            else if (method.Equals("Paypal"))
            {
                notify = new SMSNotification();
                notify.SendNotification(message);
            }
            else
            {
                notify = new PushNotification();
                notify.SendNotification(message);
            }
        }

        static void VehicleRentalSystem()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Car("SDJS752","Maruti Alto"));
            vehicles.Add(new Bike("JDVU138", "TVS Raider"));

            Vehicle vehicle;
            Console.Write("Please enter your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("---Only available vehicles will be assigned---");
            Console.Write("Please enter your vehicle(Bike/Car) : ");
            string type = Console.ReadLine();
            Console.Write("Please enter time(in hrs) : ");
            int time = Convert.ToInt32(Console.ReadLine());
            if (type.Equals("Bike"))
            {
                vehicle = new Bike(vehicles[1].VehicleNumber, vehicles[1].VehicleModel);
                vehicle.DisplayDetails(type, name);
                vehicle.CalculateRentalPrice(time);
            }
            vehicle = new Car(vehicles[0].VehicleNumber, vehicles[0].VehicleModel);
            vehicle.DisplayDetails(type, name);
            vehicle.CalculateRentalPrice(time);
        }

        static void EmployeePayrollSystem()
        {
            Employee employee;
            Console.Write("Please enter your name : ");
            string empName = Console.ReadLine();
            Console.Write("Please enter your id : ");
            string empId = Console.ReadLine();
            Console.Write("Please enter your type(FullTime/Contract) : ");
            string empType = Console.ReadLine();
            int hours = 0;
            if (empType.Equals("Contract"))
            {
                Console.Write("Please enter no of hours worked :");
                hours = Convert.ToInt32(Console.ReadLine());
            }

            if (empType.Equals("FullTime"))
            {
                employee = new FullTimeEmployee(empName,empId,empType);
                employee.CalculateSalary(null);
            }
            employee = new ContractEmployee(empName,empId,empType);
            employee.CalculateSalary(hours);
        }

        static void OnlineDiscountSystem()
        {
            Discount discount;
            Console.Write("Please enter the price of the product : ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Please enter discount type(Seasonal/Festival/Membership) : ");
            string discountType = Console.ReadLine();
            if (discountType.Equals("Seasonal"))
            {
                discount = new SeasonalDiscount();
                discount.CalculateDiscount(price);
            }
            else if (discountType.Equals("Festival"))
            {
                discount = new FestivalDiscount();
                discount.CalculateDiscount(price);
            }
            else
            {
                discount = new MembershipDiscount();
                discount.CalculateDiscount(price);
            }
        }
    }
}
