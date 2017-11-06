using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book
    {
        
        public string ItemId { get; set; }
        
        public string Title { get; set; }
        
        public double Price { get; set; }


        public Book(string _itemId, string _title, double _price)
        {
            ItemId = _itemId;
            Title = _title;
            Price = _price;
        }
        public Book(string _itemId, string _title):
            this(_itemId, _title, 0)
        {
        }
        public Book(string _itemId):
            this(_itemId, string.Empty, 0)
        {
        }

        public Book():
            this(string.Empty, string.Empty, 0)
        {

        }

        public override string ToString()
        {
            NumberFormatInfo dotToComma = new NumberFormatInfo();
            dotToComma.NumberDecimalSeparator = ",";
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price.ToString(dotToComma);
        }
    }
}
