using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menumedarrayosv
{
    public class Menu
    {
        public string Title;
        private MenuItem[] menuItems;
        private int itemCount = 0;
        public Menu()
        {
            menuItems = new MenuItem[10];
        }

        public void Show()
        {
            Console.WriteLine(Title);
            for (int i = 0; i < itemCount; i++)
                Console.WriteLine(menuItems[i].Title);
        }
        public void AddmenuItem(string MenuTitle)
        {
            MenuItem mi = new MenuItem();
            mi.Title = MenuTitle;
            menuItems[itemCount] = mi;
            itemCount++;
        }
    }
}

