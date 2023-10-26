﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {

            if (amulet.Quality == Level.low)
            {
                return 12.5;
            }
            else if (amulet.Quality == Level.medium)
            {
                return 20.0;
            }
            else
            {
                return 27.5;
            }

        }
        public double GetValueOfCourse(Course course)
        {
            int remainder = course.DurationInMinutes % 60;
            if (remainder == 0)
            {
                return course.DurationInMinutes / 60 * 875;
            }
            else if (remainder > 0)
            {
                return (course.DurationInMinutes / 60 + 1) * 875;
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
