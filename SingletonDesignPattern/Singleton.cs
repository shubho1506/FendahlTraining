using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public class Singleton
    {
        public static Singleton Instance;  // this line will run only once
        private Singleton() { } // prevents object initialisation by other classes

        public static Singleton GetInstance() // get method creates obj when called first time and returns the same obj on subsequent calls
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

    }
}
