using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gitdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = CreatePersonAndAddress();

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} works at {1}", item.Key.ToString(), item.Value.ToString());
            }
        }

        private static Dictionary<Person, Address> CreatePersonAndAddress()
        {
            Person p = new Person()
            {
                FirstName = "Joseph",
                LastName = "DeCarlo"
            };

            Address address = new Address()
            {
                StreetAddress = "250 Williams",
                City = "Atlanta",
                State = "GA",
                ZipCode = 30303
            };

            var d = new Dictionary<Person, Address>();

            d.Add(p, address);

            return d;
        }

    }
}
