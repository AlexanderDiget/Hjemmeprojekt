using TotallySafeLib;

namespace CustomExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int skrt = TotallySafe.GetValueAtPosition(-2);

            try
            {
                int posValue = TotallySafe.GetValueAtPosition(-1);
                Console.WriteLine(posValue);
            }
            catch (NegativeIndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //try
            //{
            //    int posValue = TotallySafe.GetValueAtPosition(-2);

            //    Console.WriteLine(posValue);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NegativeIndexOutOfRangeException ex1)
            //{
            //    Console.WriteLine(ex1.Message);
            //}

            //try
            //{
            //double number = TotallySafe.Divider(0);
            //}
            //catch (DivideByZeroException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //try
            //{
            //int StringToConvert = TotallySafe.StringToInt("to"); 
            //}
            //catch (FormatException ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            Console.ReadLine();
        }

    }
}