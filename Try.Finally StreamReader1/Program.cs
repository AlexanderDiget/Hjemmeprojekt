namespace Try.Finally_StreamReader1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "test.txt";
            StreamWriter SW = new StreamWriter(fileName);
            SW.WriteLine("Hejsa");
            SW.Close();
            
        }
    }
}