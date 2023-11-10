using System.Security.Cryptography.X509Certificates;

namespace Tusindfryd
{
    public class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            try
            {
            controller.AddToList("Rose", 30, 25, 7);
            Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}