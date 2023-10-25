using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PersistensTest1
{
    public class DataHandler
    {
        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }
        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }
        public void SavePerson(Person person)
        {
            StreamWriter SW = new StreamWriter(dataFileName);
            SW.WriteLine(person.MakeTitle());
            SW.Close();
        }
        public Person LoadPerson()
        {
            StreamReader SR = new StreamReader(dataFileName);
            string lines = SR.ReadLine();
            string[] pArray = lines.Split(';');

            Person newPerson = new Person(pArray[0], Convert.ToDateTime(pArray[1]), Convert.ToDouble(pArray[2]), Convert.ToBoolean(pArray[3]), Convert.ToInt32(pArray[4]));
            SR.Close();
            return newPerson;
        }

        public void SavePersons(Person[] persons)
        {
            StreamWriter SW = new StreamWriter(dataFileName);
            for (int i = 0; i < persons.Length; i++)
            {
                SW.WriteLine(persons[i].MakeTitle());
            }




            SW.Close();
        }

        public Person[] LoadPersons();
        {
        StreamReader SR1 = new StreamReader(dataFileName);


        }


        
        
        
    }
}
