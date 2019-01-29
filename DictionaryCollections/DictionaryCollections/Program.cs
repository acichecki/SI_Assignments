using System;
using System.Collections;
namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("0", "zero");
            hashtable.Add("1", "one");
            hashtable.Add("2", "two");
            hashtable.Add("3", "three");
            hashtable.Add("4", "four");
            hashtable.Add("5", "five");
            hashtable.Add("6", "six");
            hashtable.Add("7", "seven");
            hashtable.Add("8", "eight");
            hashtable.Add("9", "nine");

            string someString = "032134512387";

            foreach (var number in someString)
            {
                Console.WriteLine(hashtable[number.ToString()]);
            }
            
            Console.ReadKey();
        }
    }
}
