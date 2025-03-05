using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesAndObjects
{
    //Regular Class → Standard class (objects can be created) - ✅ 
    //Static Class → No object creation, used for utility functions. - ✅
    //Abstract Class → Must be inherited, cannot be instantiated. - ✅ 
    //Sealed Class → Prevents inheritance. - ✅ 
    //Partial Class → Defined across multiple files. - ✅ 
    //Nested Class → A class inside another class. - ✅ 
    //Generic Class → Works with multiple data types. - ✅ 
    //Anonymous Class → No class definition, used for temporary objects. - ✅ 
    //Record Class → Immutable, introduced in C# 9+.//Unavailable due to lower language version
    class Program
    {
        class Person 
        {
            public string Name { get; set; } 
            public int Age { get; set; } 
        }

        static void Main(string[] args)
        {
            Regular rg = new Regular();
            rg.SayRegular();
            StaticClass.SayStatic();
            AbstractImplement abs = new AbstractImplement();
            abs.SayAbstract();
            SealedClass sc = new SealedClass();
            sc.SaySealed();
            PartialClass pc = new PartialClass();
            pc.SayPartialClass1();
            pc.SayPartialClass2();
            NestedClass.Nested nc = new NestedClass.Nested();
            nc.SayNested();
            //Anonymous Class
            var person = new { Name = "John", Age = 25 };
            Console.WriteLine(person.Name + " is " + person.Age + " years old.");

            // Using Generic Class with Integer
            GenericClasses<int> intObj = new GenericClasses<int>(100);
            intObj.Display();  // Output: Stored Value: 100

            // Using Generic Class with String
            GenericClasses<string> stringObj = new GenericClasses<string>("Hello, Generics!");
            stringObj.Display();  // Output: Stored Value: Hello, Generics!

            //object Creation Types
            // 1️⃣ Standard Object Creation using new
            ObjectCreationDemo obj1 = new ObjectCreationDemo("Alice", 25);
            obj1.Display();

            // 2️⃣ Object creation using Factory Method
            ObjectCreationDemo obj2 = ObjectCreationDemo.CreateObject("Bob", 30);
            obj2.Display();

            // 3️⃣ Object creation using Reflection
            ObjectCreationDemo obj3 = ObjectCreationDemo.CreateUsingReflection();
            obj3.Name = "Charlie";
            obj3.Age = 35;
            obj3.Display();

            // 5️⃣ Shallow Copy Example
            ObjectCreationDemo obj4 = obj1.ShallowCopy();
            Console.WriteLine("Shallow Copy:");
            obj4.Display();

            // 6️⃣ Deep Copy Example
            ObjectCreationDemo obj5 = obj1.DeepCopy();
            Console.WriteLine("Deep Copy:");
            obj5.Display();

            // 7️⃣ Anonymous Object (Temporary Use)
            var anonymousObj = new { Name = "David", Age = 40 };
            Console.WriteLine($"Anonymous Object: Name = {anonymousObj.Name}, Age = {anonymousObj.Age}");

            //Json Formatting 
            var person1 = new { Name = "Alice", Age = 25 };
            string jsonString = JsonSerializer.Serialize(person1);
            Console.WriteLine(jsonString); // Output: {"Name":"Alice","Age":25}

            string json = "{\"Name\":\"Alice\",\"Age\":25}";
            Person p = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(p.Name); // Output: Alice
        }
}
}
