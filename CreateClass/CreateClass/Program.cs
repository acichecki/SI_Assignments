using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Krzysio = new Person() { Name = "Krzysio", BirthDate = new DateTime(1989, 3, 14), Gender = Person.Genders.Male};
            Console.Write(Krzysio.ToString());
            Console.ReadLine();
        }
    }
}
