using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            IValuable valuable = null;
            if (valuables.Count > 0)
            {
                foreach (IValuable val in valuables)
                {
                    if (val is Book)
                    {
                        Book b = (Book)val;
                        if (id == b.ItemId)
                        {
                            valuable = b;
                        }
                    }
                    else if (val is Amulet)
                    {
                        Amulet a = (Amulet)val;
                        if (id == a.ItemId)
                        {
                            valuable = a;
                        }
                    }
                    else if (val is Course) 
                    {
                        Course c = (Course)val;
                        if (id == c.Name)
                        {
                            valuable = c;
                        }
                    }
                }
            }
            return valuable;
        }
        public double GetTotalValue()
        {

        }
        public int count()
        {
            
        }
    }
}
