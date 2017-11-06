using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course
    {
       public string Name { get; set; }

       public int DurationInMinutes { get; set; }

        public Course(string name, int duration)
        {
            Name = name;
            DurationInMinutes = duration;
        }

        public Course(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes;
        }
    }
}
