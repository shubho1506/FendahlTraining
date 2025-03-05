using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExamples
{
    class Program
    {


        class Base
        {
            public void SayHello()
            {
                Console.WriteLine("This is base class. ");
            }
        }

        class Derived : Base
        {
            public new void SayHello()
            {
                base.SayHello();
                Console.WriteLine("This is derived class. ");
            }
        }

        static void MethodOverriding()
        {
            Base baseClass = new Base();
            baseClass.SayHello();
            Base obj = new Derived();
            obj.SayHello();
            Derived derivedClass = new Derived();
            derivedClass.SayHello();
        }
        static void Main(string[] args)
        {
            //MethodOverriding();
            //BonusCalculator();
            //PaymentTransfer();
            //SmartHomeDeviceControlSystem();
            RestaurantOrderingSystem();
        }

        static void BonusCalculator()
        {
            Employee emp;
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter your empId : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter your designation (Developer/Manager/Admin) : ");
            string designation = Console.ReadLine();
            Console.Write("Please enter your salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (designation.Equals("Developer"))
            {
                emp = new Developer(name, empId, salary, designation);
                double bonus = emp.getBonus(salary);
                Console.WriteLine($"Your bonus will be {bonus}");
            }
            else if (designation.Equals("Manager"))
            {
                emp = new Manager(name, empId, salary, designation);
                double bonus = emp.getBonus(salary);
                Console.WriteLine($"Your bonus will be {bonus}");
            }
            else
            {
                emp = new Admin(name, empId, salary, designation);
                double bonus = emp.getBonus(salary);
                Console.WriteLine($"Your bonus will be {bonus}");
            }
        }

        static void PaymentTransfer()
        {
            Payment payment;
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.Write("Please enter your amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your payment method (Credit card/Paypal/BankTransfer) : ");
            string method = Console.ReadLine();
            if(method.Equals("Credit card"))
            {
                payment = new CreditCard(name, amount);
                payment.ProcessPayment(amount);
            }
            else if (method.Equals("Paypal"))
            {
                payment = new PayPal(name, amount);
                payment.ProcessPayment(amount);
            }
            else
            {
                payment = new BankTransfer(name, amount);
                payment.ProcessPayment(amount,10);
            }
        }

        static void SmartHomeDeviceControlSystem()
        {
            SmartDevice device;
            Console.Write("Please enter your duration : ");
            int duration = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your device type (SmartLight/SmartAC/SmartTV) : ");
            string method = Console.ReadLine();
            if (method.Equals("SmartLight"))
            {
                device = new SmartLight();
                device.TurnOn(duration);
            }
            else if (method.Equals("SmartAC"))
            {
                device = new SmartAC();
                device.TurnOn(duration);
            }
            else
            {
                device = new SmartTV();
                device.TurnOn(duration);
            }
        }

        static void RestaurantOrderingSystem()
        {
            Order order;
            Console.Write("Please enter your dish : ");
            string dish = Console.ReadLine();
            Console.Write("Please enter your type(Mild/Spicy) (* default - Mild) : ");
            string type = Console.ReadLine();
            Console.Write("Your order type (DineIn/Takeaway/Online) : ");
            string orderType = Console.ReadLine();
            if (orderType.Equals("DineIn"))
            {
                order = new DineInOrder();
                order.PlaceOrder(dish);
            }
            else if (orderType.Equals("Takeaway"))
            {
                order = new TakeawayOrder();
                order.PlaceOrder(dish);
            }
            else
            {
                order = new OnlineOrder();
                order.PlaceOrder(dish,type);
            }
        }
    }
}
