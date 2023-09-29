namespace PersistensTest1
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int names = 3;
            Person[] persons = new Person[names];
            persons[0] = new Person("Ulla Pedersen", new DateTime(1994, 3, 29), 186.5, false, 1);
            persons[1] = new Person("Sully Pedersen", new DateTime(1995, 4, 30), 187, true, 2);
            persons[2] = new Person("Henrik Plovmand", new DateTime(1965, 5, 31), 188, false, 3);

            //Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

            DataHandler handler = new DataHandler("Data.txt");
            handler.SavePersons(persons);

            Console.WriteLine("Writing Person: ");
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].MakeTitle());
            }
            
            //Console.WriteLine(person.MakeTitle());

          
            

            Console.ReadLine();
        }
    }
}