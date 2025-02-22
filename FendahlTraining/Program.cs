using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FendahlTraining
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //PartialClass partial = new PartialClass();
            //partial.ShowName();
            //partial.ShowCollege();

            //Employee emp = new Employee("Shubhodeep", 001);
            //Console.WriteLine(emp.getName());
            //Console.WriteLine(emp.getEmpId());
            //emp.setName("Sarkar");
            //emp.setEmpId(007);

            //Console.WriteLine(emp.getName());
            //Console.WriteLine(emp.getEmpId());

            //int a = default(int);
            //Console.WriteLine(a);

            //int b = 10;
            //var c = &b;
            //b = 20;
            //Console.WriteLine(c);
            //Console.WriteLine(b);


            //referencing
            //Person p1 = new Person();
            //p1.Age = 1;
            //Console.WriteLine(p1.Age);

            //Person p2 = new Person();
            //p2 = p1;
            //p2.Age = 2;
            //Console.WriteLine(p1.Age);
            //p1.Age++;
            //Console.WriteLine(p2.Age);
            //Console.WriteLine(p1.Age);

            string str3 = "sdsshubho";
            str3 = str3.Substring(0, 3);
            //Console.WriteLine(str3);
            string str1 = "sds";
            string str2 = str1;
            str2 = "ss";
            //string str2 = "sds";
            Console.WriteLine(str1 == str3.Substring(0, 3));
            Console.WriteLine(str1.Equals(str3.Substring(0, 3)));
        }
    }
}
