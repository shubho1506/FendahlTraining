using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    public class Repository<T> where T : class
    {
        private T entity;

        public Repository(T item)
        {
            entity = item;
        }


        public void Save(T item)
        {
            entity = item;
            Console.WriteLine($"{item} saved successfully.");
        }
    }
}
