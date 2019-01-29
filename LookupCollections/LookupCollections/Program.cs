using System;
using System.Collections;
using  System.Collections.Specialized;
using  System.Globalization;

namespace LookupCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary listDictionary = new ListDictionary(StringComparer.InvariantCultureIgnoreCase);
            listDictionary.Add("United States", "Estados Unidos");
            listDictionary.Add("Canada", "Canadá");
            listDictionary.Add("Spain", "España");

            Console.WriteLine(listDictionary["spain"]);
            Console.WriteLine(listDictionary["canada"]);

            Console.ReadKey();
        }
    }
}
