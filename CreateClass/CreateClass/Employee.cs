using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public int Salary { get; set; }
        public string Profession { get; set; }
        public Room RoomNumber { get; set; }

        public override string ToString()
        {
            return base.ToString() + ". Salary: " + Salary + ". Profession: " + Profession + ". Works in room nr " + RoomNumber.RoomNumber;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public object Clone(string WithRoom)
        {
            Employee newEmployee = new Employee();
            newEmployee.RoomNumber = new Room(RoomNumber.RoomNumber);
            return newEmployee;
        }

        public class Room
        {
            public int RoomNumber { get; set; }

            public Room(int roomNumber)
            {
                this.RoomNumber = roomNumber;
            }
        }
    }
}
