using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Level { low, medium, high };

namespace Morgengry
{
    public class Amulet
    {
        public string ItemId { get; set; }
        public string Design { get; set; }
        public Level Quality { get; set; }

        public Amulet(string _itemId, Level _quality, string _design)
        {
            ItemId = _itemId;
            Quality = _quality;
            Design = _design;
        }
        public Amulet(string _itemId, Level _quality) :
            this(_itemId, _quality, string.Empty)
        {
        }
        public Amulet(string _itemId) :
            this(_itemId, Level.medium, string.Empty)
        {
            ItemId = _itemId;
        }
        
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality.ToString() + ", Design: " + Design;
        }
        
        

        
    }
}
