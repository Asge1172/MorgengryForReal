using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class BookRepository
    {
        List<Book> bookList = new List<Book>();

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public Book GetBook(string itemId)
        {
            Book result = null;
            int i = 0;
            bool findBook = true;
            while(findBook)
            {
                if (bookList[i].ItemId == itemId)
                {
                    result = bookList[i];
                    findBook = false;
                }
                if (bookList.Count <= i)
                {
                    findBook = false;
                }
                i += 1;
            }
            return result;
        }

        public double GetTotalValue()
        {
            double result = 0;
            foreach (Book bookPrice in bookList)
            {
                result += bookPrice.Price;
            }
            return result;
        }
    }
}
