using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public Amulet? GetAmulet(string itemId)
        {
            Amulet? amulet = null;
            if (amulets.Count > 0)
            {
                foreach (Amulet a in amulets)
                {
                    if (itemId == a.ItemId)
                    {
                        amulet = a;
                    }
                }
            }
            return amulet;
        }
        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double totalValueAmulet = 0;
            foreach (Amulet amulet in amulets)
            {
                double amuletValue = utility.GetValueOfAmulet(amulet);
                totalValueAmulet += amuletValue;
            }
            return totalValueAmulet;
        }
    }
}
