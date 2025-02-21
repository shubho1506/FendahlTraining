using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConcepts
{
    class Person
    {
        public string Name;
        public Address Address;  // Reference Type

        // **Shallow Copy**
        public Person ShallowCopy()
        {
            // Creating a new Person object but copying the reference of Address
            Person newPerson = new Person(this.Name, this.Address);
            return newPerson;  // Address is shared (not independent)
        }

        // **Deep Copy**
        public Person DeepCopy()
        {
            // Creating a new Person object and creating a new Address object too
            Person newPerson = new Person(this.Name, new Address(this.Address));
            return newPerson;  // Completely independent copy
        }

        public Person(string name, Address address)
        {
            this.Name = name;
            this.Address = address;
        }

        // **Deep Copy using Copy Constructor**
        public Person(Person person)
        {
            this.Name = person.Name;
            this.Address = new Address(person.Address); // Creating a new Address object
        }
    }
}
