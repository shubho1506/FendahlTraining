using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTraining
{
    //static class Hello
    //{
    //    static Hello()
    //    {
    //        Console.WriteLine("This is hello class");
    //    }
    //}

    //class ParentClass
    //{
    //    public void Parent()
    //    {
    //        Console.WriteLine("This is parent class");
    //    }
    //}

    //class DaughterClass
    //{
    //    public void Daughter()
    //    {
    //        Console.WriteLine("This is parent class");
    //    }
    //}

    //abstract class Base
    //{
    //    private Base() 
    //    {
    //        Console.WriteLine("Base class private constructor");
    //    }

    //    public static Base CreateInstance()
    //    {
    //        return new Basebase(); 
    //    }

    //    public abstract void SayHello();

    //    internal class Basebase : Base
    //    {
    //        public Basebase()
    //        {

    //        }
    //        public override void SayHello()
    //        {
    //            Console.WriteLine("This is basebase class"); ;
    //        }

    //        Base h = CreateInstance();
    //    }
    //}

    //class Derived : Base
    //{
    //    //public Derived()
    //    //{
    //    //    Console.WriteLine("Derived class constructor");
    //    //}

    //    public override void SayHello()
    //    {
    //        Console.WriteLine("Hello from Derived class");
    //    }
    //}

    internal abstract class P
    {
        private P()
        {
            Console.WriteLine("Private Constructor");
        }
        public static void Hii()
        {
            Console.WriteLine("Hii");
        }
        internal static P GetP() => new P1();
        internal class P1 : P
        {
            internal P1() { }
        }
    }

    static internal class Index
    {
        static string name { get; set; } = "";
        static Index()
        {
            P.Hii();
            P obj = new P.P1();
        }
    }

    abstract class AbstractClass
    {
        string name;

        private AbstractClass(string name)  // ✅ Private Constructor
        {
            Console.WriteLine("Abstract Class Constructor");
            this.name = name;
        }

        //  Static Factory Method to Create an Instance
        public static AbstractClass CreateInstance(string name)
        {
            return new Nestedclass(name);
        }

        //  Nested Class to Access the Private Constructor
        public class Nestedclass : AbstractClass
        {
            public Nestedclass(string name) : base(name)
            {
                Console.WriteLine("Nested Class Constructor");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Base obj = Base.CreateInstance(); 
            //obj.SayHello();

            //Base obj = new Base.Basebase();

            //P obj1 = new P.P1();

            C1.method();

            AbstractClass instance = AbstractClass.CreateInstance("Tanmay");
            // Accessing private constructor indirectly via Nestedclass

        }
    }


    class C1
    {
        public static void method()
        {
            Console.WriteLine("This is c1 method");
        }
    }

    class C2 : C1
    {
        public static void method()
        {
            Console.WriteLine("This  is c2 class. ");
        }
    }


    
}
