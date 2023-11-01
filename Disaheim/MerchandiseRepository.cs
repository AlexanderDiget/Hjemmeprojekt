using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }
        public Merchandise? GetMerchandise(string itemId)
        {
            Merchandise? merchandise = null;
            if (merchandises.Count > 0)
            {
                foreach (Merchandise m in merchandises)
                {
                    if (itemId == m.ItemId)
                    {
                        merchandise = m;
                    }
                }
            }
            return merchandise;
        }
        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double totalValueMerchandise = 0;
            foreach (Merchandise merchandise in merchandises)
            {
                double merchandiseValue = utility.GetValueOfMerchandise(merchandise);
                totalValueMerchandise += merchandiseValue;
            }
            return totalValueMerchandise;
        }
    }
}
