using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book? GetBook(string itemId)
        {
            Book? book = null;
            if (books.Count > 0)
            {
                foreach (Book b in books)
                {
                    if (itemId == b.ItemId)
                    {
                        book = b;
                    } 
                }
            }
            return book;
        }
        public double GetTotalValue()
        {
            Utility utility = new Utility();
            double totalValueBook = 0;
            foreach (Book book in books)
            {
                double bookValue = utility.GetValueOfBook(book);
                totalValueBook += bookValue;
            }
            return totalValueBook;
        }
    }
}
