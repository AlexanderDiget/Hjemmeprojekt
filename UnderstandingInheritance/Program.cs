using System.Runtime.InteropServices;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
          Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            printCarDetails(myCar);
            Console.ReadLine();
        }
        private static void printCarDetails(Car car)
        {
            Console.WriteLine("Here are the Car's details: {0}",
                car.FormatMe());
        }
    }
    class Car 
    {
      public string Make {  get; set; }
      public string Model { get; set; }
      public int Year { get; set; }
      public string Color { get; set; }

        public string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Color,
                this.Year);
        }
    }
}