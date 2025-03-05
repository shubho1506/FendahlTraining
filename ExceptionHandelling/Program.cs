using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelling
{
    class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
            Console.WriteLine("This is custom exception !!! ");
        } 
    }

    class First
    {
        public void Method1()
        {
            try
            {
                Second obj = new Second();
                obj.method2();
            }
            catch(Exception e)
            {
                Console.WriteLine("This is class First and method 1. ");
                throw;
            }
        }
    }

    class Second
    {
        public void method2()
        {
            try
            {
                Third obj = new Third();
                obj.method3(9);
            }
            catch(CustomException e)
            {
                Console.WriteLine("This is class Second and method 2. ");
                throw;
            }
        }
    }

    class Third
    {
        public void method3(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("This is class Third and method 3. ");
                throw new CustomException("Custom Exception: Age must be 18 or older.");
            }
            Console.WriteLine("Age is valid.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                First obj = new First();
                obj.Method1();
            }
            catch(Exception e)
            {
                Console.WriteLine("This is Main method and exception detail : " + e.Message);
            }
            finally
            {
                Console.WriteLine("This is finally block. ");
            }
        }
    }
}
