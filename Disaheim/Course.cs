using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }
        public static double CourseHourValue { get; set; } = 875.0;

        public Course(string name, int durationInMinutes) : this(name)
        {
           DurationInMinutes = durationInMinutes;
           
        }
        public Course(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";
        }
    }
}
