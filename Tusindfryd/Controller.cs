using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Tusindfryd
{
    public class Controller
    {
        private FlowerRepository flowerRepo = new FlowerRepository();
        public Controller()
        {
            
        }
        public void AddToList(string Name, int ProductionTimeInDays, double HalfChangeOfValue, double Size)
        {
            Flower flower = new Flower(Name, ProductionTimeInDays, HalfChangeOfValue, Size);
            flowerRepo.AddFlower(flower);
        }
        
    }
}
