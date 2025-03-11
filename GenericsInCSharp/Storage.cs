using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    // Generic Class with Type Parameter <T>
    public class Storage<T>
    {
        private T data; // Variable of Type T

        public void Store(T item) => data = item;

        public T Retrieve() => data;
    }

}
