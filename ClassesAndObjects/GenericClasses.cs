using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class GenericClasses<T>
    {
        private T data;

        public GenericClasses(T value)
        {
            data = value;
        }

        public void Display()
        {
            Console.WriteLine($"Stored Value: {data}");
        }
    }
}
