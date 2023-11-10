using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd
{
    public class Flower
    {
        public string Name { get; set; }
        public int ProductionTimeInDays { get; set; }
        public double HalfChangeOfValue { get; set;}
        public double Size {  get; set; }
        public Flower(string name, int productionTimeInDays, double halfChangeOfValue, double size) 
        {
            Name = name;
            ProductionTimeInDays = productionTimeInDays;
            HalfChangeOfValue = halfChangeOfValue;
            Size = size;
        } 
    }
}
