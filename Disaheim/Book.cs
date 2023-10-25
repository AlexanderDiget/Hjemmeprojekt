using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        public string ItemId;
        public string Title;
        public double Price;

        public Book(string itemId) 
        {
            ItemId = itemId;
        }
        public Book(string itemId, string title) : this(itemId) 
        {
            Title = title;
        }
        public Book(string itemId, string title, double price): this(itemId, title)
        {
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
