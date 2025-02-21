using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DateTimeOperationsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic practice problems of DateTime operations in C#");

            DateTimeOps t = new DateTimeOps();
            Console.WriteLine("Formating Date Problem");
            t.formating();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Adding The Time");
            t.AddFormating();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Subtracting the Time");
            t.SubFormating();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Date Comparision");
            t.DateCompare();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Date Difference");
            t.DateDifference();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Print the Date Componenets");
            t.DateComponenets();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Print the Utc date time");
            t.UtcDtaeConversion();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Print the leapYear");
            t.LeapYear();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Firts and End Date of Month");
            t.DateMont();
            Console.WriteLine("-------------------------------------------------");

            t.AdditionTime();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("COUNTDOWN");
            t.CountDown();
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
