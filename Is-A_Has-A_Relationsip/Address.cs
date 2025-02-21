using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_A_Has_A_Relationsip
{
    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public Address(string street, string city, string state, string postalCode)
        {
            Street = street;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public void DisplayAddress()
        {
            Console.WriteLine($"Address: {Street}, {City}, {State} - {PostalCode}");
        }
    }
}
