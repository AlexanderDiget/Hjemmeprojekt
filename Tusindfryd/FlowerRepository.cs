using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tusindfryd
{
    public class FlowerRepository
    {
        private List<Flower> flowers = new List<Flower>();

        public FlowerRepository()
        {

        }
        public void AddFlower(Flower flower)
        {
            try
            {
                flowers.Add(flower);
                Console.WriteLine("Flower added succesfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Flower not added succesfully ");
            }
        }
        public void RemoveFlower(Flower flower)
        {
            flowers.Remove(flower);
        }
        public void UpdateFlower(Flower flower)
        {

        }

    }
}
