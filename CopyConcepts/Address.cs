using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConcepts
{
    class Address
    {
        public string City;

        public Address(string city)
        {
            this.City = city;
        }

        // Deep Copy Constructor
        public Address(Address address)
        {
            this.City = address.City; // Creating a new Address instance with the same city value
        }
    }
}
