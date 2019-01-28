using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }

        public enum Genders
        {
            Male,
            Female
        }

        public override string ToString()
        {
            return this.Name + " was born on " + this.BirthDate.Day + "." + this.BirthDate.Month + "." + this.BirthDate.Year + " and is " + this.Gender;
        }
    }
}
