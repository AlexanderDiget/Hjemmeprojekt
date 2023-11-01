using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        //public double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}
        //public double GetValueOfAmulet(Amulet amulet)
        //{

        //    if (amulet.Quality == Level.low)
        //    {
        //        return 12.5;
        //    }
        //    else if (amulet.Quality == Level.medium)
        //    {
        //        return 20.0;
        //    }
        //    else
        //    {
        //        return 27.5;
        //    }

        //}
        public double LowQualityValue { get; set; } = 12.5;
        public double MediumQualityValue { get; set; } = 20.0;
        public double HighQualityValue { get; set; } = 27.5;
        public double CourseHourValue { get ; set; } = 875.0;


        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Book book)
            {
                return book.Price;
                //return ((Book)merchandise).Price; //Explicit casting
            }
            else if(merchandise is Amulet amulet)
            {
                if (amulet.Quality == Level.low)
                {
                    return LowQualityValue;
                }
                else if(amulet.Quality == Level.medium)
                {
                    return MediumQualityValue;
                }
                else if(amulet.Quality == Level.high)
                {
                    return HighQualityValue;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0; 
            }
        }
        public double GetValueOfCourse(Course course)
        {
            int remainder = course.DurationInMinutes % 60;
            if (remainder == 0)
            {
                return course.DurationInMinutes / 60 * CourseHourValue;
            }
            else if (remainder > 0)
            {
                return (course.DurationInMinutes / 60 + 1) * CourseHourValue;
            }
            else
            {
                return 0;
            }
            // int mudolo = course.DurationInMinutes % 60;
            // int value = (course.DurationInMinutes-modulo)/60;
            // if (mudolo > 0)
            // {
            //      value +=1;
            // }
            // return (value*875);
        }
    }
}
