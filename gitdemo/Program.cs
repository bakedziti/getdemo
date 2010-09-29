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
            throw new NotImplementedException();
        }

    }
}
