using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course? GetCourse(string name)
        {
            Course? course = null;
            if (courses.Count > 0)
            {
                foreach (Course c in courses)
                {
                    if (name == c.Name)
                    {
                        course = c;
                    }
                }
            }
            return course;
        }
        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double totalValue = 0;
            foreach (Course course in courses)
            {
                double courseValue = utility.GetValueOfCourse(course);
                totalValue += courseValue;
            }
            return totalValue;
        }
    }
}
