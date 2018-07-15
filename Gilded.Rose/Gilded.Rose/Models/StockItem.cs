namespace Gilded.Rose.Models
{
    public class StockItem
    {
       
        public string Name { get; set; }
        public int Quality { get; set; }
        public int SellIn { get; set; }
       
        public StockItem(string name, int sellIn, int quality)
        {
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }


       
    }
}
