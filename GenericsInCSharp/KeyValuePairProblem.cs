using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInCSharp
{
    //Problem 4: Key-Value Pair Class
    //Create a generic class KeyValuePair<K, V> that holds a key-value pair.
    //Add a method to display the key and value. 
    class KeyValuePairProblem<K, V>
    {
        public K Key { get; }
        public V Value { get; }

        public KeyValuePairProblem(K key, V value)
        {
            Key = key;
            Value = value;
        }

        public void Display()
        {
            Console.WriteLine($"Key: {Key}, Value: {Value}");
        }


    }
}
