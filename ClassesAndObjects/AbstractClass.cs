using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    abstract class AbstractClass
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        abstract public  void SayAbstract();
    }
}
