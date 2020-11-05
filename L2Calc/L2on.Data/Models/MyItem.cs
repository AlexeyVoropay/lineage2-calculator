using L2Calc.Common.Enums;

namespace L2on.Data.Models
{
    public class MyItem
    {
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string PriceText { get; set; }
        public long MyPrice { get; set; }
        public string MyPriceText { get; set; }
        public double? Percent { get; set; }        
        public string SpottedTime { get; set; }
        public string Other { get; set; }
        public PriceType PriceType { get; set; }

        public string GetString()
        {
            return $"{Name}/{Price}/{Other}/{SpottedTime}";
        }
    }
}