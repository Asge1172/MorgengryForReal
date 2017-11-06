using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class CourseRepository
    {
        List<Course> CourseList = new List<Course>();

        public void AddCourse(Course course)
        {
            CourseList.Add(course);
        }

        public Course GetCourse(string name)
        {
            Course result = null;
            int i = 0;
            bool findCourse = true;
            while (findCourse)
            {
                if (CourseList[i].Name == name)
                {
                    result = CourseList[i];
                    findCourse = false;
                }
                if (CourseList.Count <= i)
                {
                    findCourse = false;
                }
                i += 1;
            }
            return result;
        }

        public double GetTotalValue()
        {
            double result = 0;
            foreach (Course CoursePrice in CourseList)
            {

                result += Utility.GetValueOfCourse(CoursePrice);
            }
            return result;
        }
    }
}

