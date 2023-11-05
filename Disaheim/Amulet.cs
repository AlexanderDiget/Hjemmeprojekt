using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        public string ItemId {  get; set; }
        public string Design {  get; set; }
        public Level Quality {  get; set; }
        public static double LowQualityValue { get; set; } = 12.5;
        public static double MediumQualityValue { get; set; } = 20.0;
        public static double HighQualityValue { get; set; } = 27.5;

        public Amulet(string itemId, Level quality, string design) : this(itemId, quality)
        {
            Design = design;
        }

        public Amulet(string itemId, Level quality): this(itemId)
        {
            Quality = quality;
        }
        public Amulet(string itemId) 
        {
            ItemId = itemId;
            Quality = Level.medium;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

    }
}
