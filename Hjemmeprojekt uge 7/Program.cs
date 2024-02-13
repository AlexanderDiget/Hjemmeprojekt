using System.Reflection.Metadata;

namespace Hjemmeprojekt_uge_7
{
    public class Program /*Access modifier er her manuelt lavet fra internal til public 
                          *da programmet skal kunne tilgå klasser når de er lavet
        */
    {
        static void Main(string[] args)
        {
            /*Fremgangsmåde for at lave variabler
            1. Declaration
            2. Initialization
            */

            int x;    //1. Declaration //int = heltal
            x = 20;   //2. Initialization

            //Eksempler:
            int age = 23;              //int = heltal, declaration og Initialization kombineret
            string name = "Alexander"; //string = tekststreng
            double height = 1.76;      //double = et decimaltal 
            bool gender = true;        //Bool = enten true eller false statement
            char symbol = '@';         //char = kun en enkelt character hvorimod string kan man bruge mange

            //Man kan også bruge ovenstående tal værdier og bruge dem med matematik fx:
            int z = x + age;

            //man kan bruge dem på forskellige måder herunder nogle eksempler:

            Console.WriteLine(x);
            Console.WriteLine(age);
            Console.WriteLine(z);

            Console.WriteLine("Din alder er " + age);
            Console.WriteLine("Dit navn er " + name);
            Console.WriteLine("Din højde er " +  height);
            Console.WriteLine("Er du en mand? " + gender);

            Console.WriteLine("Dit navn er " + name + ", du er " +  age + " år gammel" + " og du er " + height + " meter høj");
            Console.WriteLine("Er du en mand? " + gender);
            Console.WriteLine("Dit symbol er " +  symbol);

            string userName = symbol + name;
            Console.WriteLine("Dit username er: " + userName);
            Console.ReadLine();

            //constants = Konstante variabler hvorved det giver mening at folk ikke skal kunne ændre på værdien
            // på den givne variabler så fx:

            double pi = 3.14159;
            //værdien pi er en konstant værdi og er ikke noget man burde ændre
            pi = 420;
            //her har man dog formået at ændre værdien af variablen "pi" hvilket ikke giver mening og gøre programmet mindre sikkert i den forstand

            //Man kan derfor oprette konstante værdier som variablerved at sige således:
            const double pi1 = 3.14159;
            //Denne værdi er nu konstant og kan ikke ændres
            //pi1 = 420; virker altså ikke

        }
    }
}
