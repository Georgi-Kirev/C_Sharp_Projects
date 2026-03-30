
public class Box
{
    // Properties / Характеристики
    public int SerialNumber { get; set; }
    public string Item { get; set; }
    public int ItemQuantity { get; set; }
    public double PriceForTheBox { get; set; }

    // Конструктор

    public Box(int serialNumber, string item, int itemQuantity, double priceForTheBox)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        PriceForTheBox = priceForTheBox;
    }


}

