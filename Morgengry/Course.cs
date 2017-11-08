using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
       public string Name { get; set; }

       public int DurationInMinutes { get; set; }
       public double CourseHourValue { get; set; } = 825;

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
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue;
        }

        public double GetValue()
        {
            
            int hour = DurationInMinutes / 60;
            if (DurationInMinutes % 60 > 0 )
            {
                hour++;
            }
            return hour * CourseHourValue;

           // return result;
        }
    }
}
