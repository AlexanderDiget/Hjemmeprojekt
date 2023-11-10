namespace Try.Finally_StreamReader1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test1.txt";
            StreamReader SR = null;
            StreamWriter SW = null;

            try
            {
            SW = new StreamWriter(fileName);
            SW.WriteLine("Hejsa");
            SW.WriteLine("Hejsa1");
            SW.WriteLine("Hejsa2");
            }
            finally
            {
            SW.Close();
            }
            try
            {
            SR = new StreamReader(fileName);
            Console.WriteLine(SR.ReadToEnd());
            }
            finally
            {
            SR.Close();
            }
        }
    }
}