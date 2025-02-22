using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class ObjectCreationDemo
    {
        public string Name;
        public int Age;

        // ✅ 1️⃣ Parameterless Constructor (Required for Reflection)
        public ObjectCreationDemo()
        {
            Name = "Default";
            Age = 0;
        }

        // ✅ 2️⃣ Parameterized Constructor
        public ObjectCreationDemo(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // 2️⃣ Factory Method
        public static ObjectCreationDemo CreateObject(string name, int age)
        {
            return new ObjectCreationDemo(name, age);
        }

        // 3️⃣ Reflection-based object creation
        public static ObjectCreationDemo CreateUsingReflection()
        {
            Type type = typeof(ObjectCreationDemo);
            return (ObjectCreationDemo)Activator.CreateInstance(type);
        }

        // 5️⃣ Shallow Copy Method
        public ObjectCreationDemo ShallowCopy()
        {
            return this; // Copies reference only, not data.
        }

        // 6️⃣ Deep Copy Method
        public ObjectCreationDemo DeepCopy()
        {
            return new ObjectCreationDemo(this.Name, this.Age); // Creates a new object with the same values.
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
}
