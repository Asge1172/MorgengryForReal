using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum Level { low, medium, high };

namespace Morgengry
{
    public class Amulet : Merchandise
    {
        public string Design { get; set; }
        public Level Quality { get; set; }
        public double LowQualityValue { get; set; }
        public double MediumQualityValue { get; set; }
        public double HighQualityValue { get; set; }

        public Amulet(string _itemId, Level _quality, string _design)
        {
            ItemId = _itemId;
            Quality = _quality;
            Design = _design;
           
            LowQualityValue = 12.5;
            MediumQualityValue = 20.0;
            HighQualityValue = 27.5;
            
        }
        public Amulet(string _itemId, Level _quality) :
            this(_itemId, _quality, string.Empty)
        {
            LowQualityValue = 12.5;
            MediumQualityValue = 20.0;
            HighQualityValue = 27.5;
        }
        public Amulet(string _itemId) :
            this(_itemId, Level.medium, string.Empty)
        {
            ItemId = _itemId;
            LowQualityValue = 12.5;
            MediumQualityValue = 20.0;
            HighQualityValue = 27.5;
        }
        
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality.ToString() + ", Design: " + Design;
        }

        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.low:
                    return LowQualityValue;

                case Level.medium:
                    return MediumQualityValue;

                case Level.high:
                    return HighQualityValue;

                default:
                    return 0;

            }
        }


    }
}
