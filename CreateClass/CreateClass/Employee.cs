using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room RoomNumber { get; set; }

        public override string ToString()
        {
            return base.ToString() + ". Salary: " + Salary + ". Profession: " + Profession + ". Works in room nr " + RoomNumber.RoomNumber;
        }

        public class Room
        {
            public int RoomNumber { get; set; }
        }
    }
}
