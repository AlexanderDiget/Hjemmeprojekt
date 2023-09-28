using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistensTest1
{
    public class Person
    {
        private string name;
        private DateTime birthDate;
        private double height;
        private bool isMarried;
        private int noOfChildren;

        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren)
        {
            Name = name;
            BirthDate = birthDate;
            Height = height;
            IsMarried = isMarried;
            NoOfChildren = noOfChildren;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool IsMarried
        {
            get { return isMarried; }
            set { isMarried = value; }
        }

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set { noOfChildren = value; }
        }

        public string MakeTitle()
        {
            return name + ";" + birthDate + ";" + height + ";" + isMarried + ";" + noOfChildren;
            
        }
        // BirthDay.ToString("dd-MM-yyyy HH':'mm':'ss") hvis windows er på et andet sprog. Sikrer at unittest er korrekt selvom sproget er anderledes
        // Sættes ind istedet for "birthDate"
    }
}

