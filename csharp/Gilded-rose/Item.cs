namespace Gilded_rose;

public class Item
{
    public Item(string name, int sellIn, int quality)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
    }

    public string Name { get; set; }

    public int SellIn { get; set; }

    public int Quality { get; set; }
}