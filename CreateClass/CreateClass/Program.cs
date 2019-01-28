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
            Employee Krzyslav = new Employee()
            {
                Name = "Krzyslav",
                BirthDate = new DateTime(1989, 3, 14),
                Gender = Person.Genders.Male,
                Salary = 3000,
                Profession = "JS Dev",
                RoomNumber = new Employee.Room(5)
            };

            Console.WriteLine(Krzysio.ToString());
            Console.Write(Krzyslav.ToString());

            Employee Kovacs = new Employee() { Name = "Géza", BirthDate = DateTime.Now, Salary = 1000, Profession = "léhűtő" };
            Kovacs.RoomNumber = new Employee.Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.RoomNumber.RoomNumber = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }
}
