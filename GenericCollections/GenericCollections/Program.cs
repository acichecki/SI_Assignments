using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(123, "Poland");
            dictionary.Add(132, "Moland");
            dictionary.Add(211, "Doland");
            dictionary.Add(431, "Coland");
            dictionary.Add(121, "Zoland");

            //dictionary.Add("1", "Poland");

            Console.WriteLine(dictionary[431]);

            foreach (var keyValuePair in dictionary)
            {
                Console.WriteLine(keyValuePair.Key + " : " + keyValuePair.Value);
            } 

            Console.ReadKey();
        }
    }
}
