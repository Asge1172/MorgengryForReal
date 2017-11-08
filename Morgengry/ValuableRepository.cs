using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public interface IValuable
    {
        double GetValue();
    }

    public class ValuableRepository
    {
        List<IValuable> valuables = new List<IValuable>();


        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string itemId)
        {
            
            IValuable result = null;
           
            foreach (IValuable item in valuables)
            {
                if (item is book book && book.ItemId == itemId)
                {
                        result = item;
                }
                else if (item is Amulet amulet)
                {
                    if (amulet.ItemId == itemId)
                    { return item; }

                    else if (item is Course course)
                    { 
                        if (course.Name == itemId)
                        { return item; }
                    }
                }

            }
            return result;
        }  
        public double GetTotalValue()
        {
            double result = 0;
            foreach (IValuable item in valuables)
            {
                if (item is book book)
                {
                    result += book.GetValue();
                }
                if (item is Amulet amulet)
                {
                    result += amulet.GetValue();
                }
                if (item is Course course)
                {
                    result += course.GetValue();
                }
            }
            return result;
        }
        public int Count()
        {
            return valuables.Count;
        }


    }
}
