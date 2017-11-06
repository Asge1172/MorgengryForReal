using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class MerchandiseRepository
    {
        public class AmuletRepository
        {
            List<Amulet> AmuletList = new List<Amulet>();

            public void AddAmulet(Amulet amulet)
            {
                AmuletList.Add(amulet);
            }

            public Amulet GetAmulet(string itemId)
            {
                Amulet result = null;
                int i = 0;
                bool findAmulet = true;
                while (findAmulet)
                {
                    if (AmuletList[i].ItemId == itemId)
                    {
                        result = AmuletList[i];
                        findAmulet = false;
                    }
                    if (AmuletList.Count <= i)
                    {
                        findAmulet = false;
                    }
                    i += 1;
                }
                return result;
            }

            public double GetTotalValue()
            {
                double result = 0;
                foreach (Amulet AmuletPrice in AmuletList)
                {
                    switch (AmuletPrice.Quality)
                    {
                        case Level.low:
                            result += 12.5;
                            break;

                        case Level.medium:
                            result += 20.0;
                            break;

                        case Level.high:
                            result += 27.5;
                            break;

                        default:
                            break;

                    }
                }
                return result;
            }
        }
    }
}
