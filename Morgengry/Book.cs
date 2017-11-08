using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class book : Merchandise
    {        
        public string Title { get; set; }
        
        public double Price { get; set; }


        public book(string _itemId, string _title, double _price)
        {
            ItemId = _itemId;
            Title = _title;
            Price = _price;
        }
        public book(string _itemId, string _title):
            this(_itemId, _title, 0)
        {
        }
        public book(string _itemId):
            this(_itemId, string.Empty, 0)
        {
        }

        public book():
            this(string.Empty, string.Empty, 0)
        {

        }

        public override string ToString()
        {
            NumberFormatInfo dotToComma = new NumberFormatInfo();
            dotToComma.NumberDecimalSeparator = ",";
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price.ToString(dotToComma);
        }
        public override double GetValue()
        {
            return Price;
        }

    }
}
