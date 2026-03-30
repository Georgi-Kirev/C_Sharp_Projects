

public class Program
{

    public static void Main(string[] args)
    {

        string data = Console.ReadLine();
        List<Item> itemsList = new List<Item>();
        List<Box> boxesList = new List<Box>();


        while (data != "end")
        {
            int serialNumberForTheItem = int.Parse(data.Split(" ")[0]);
            string itemNameForTheItem = data.Split(" ")[1];
            int itemQuantityForTheItem = int.Parse(data.Split(" ")[2]);
            double priceForTheItem = double.Parse(data.Split(" ")[3]);

            double priceForTheBoxForTheItem = itemQuantityForTheItem * priceForTheItem;

            Item itemNameAndPrice = new Item(itemNameForTheItem, priceForTheItem);
            itemsList.Add(itemNameAndPrice);

            Box boxCalculationAndPrice = new Box(serialNumberForTheItem, itemNameForTheItem, itemQuantityForTheItem, priceForTheBoxForTheItem);
            boxesList.Add(boxCalculationAndPrice);


            data = Console.ReadLine();
        }

        boxesList = boxesList.OrderByDescending(box => box.PriceForTheBox).ToList();

        foreach (Box box in boxesList)
        {
            foreach (Item item in itemsList)
            {
                if (box.Item == item.Name)
                {
                    Console.WriteLine(box.SerialNumber);
                    Console.WriteLine($"-- {box.Item} - ${item.Price:F2}: {box.ItemQuantity}");
                    Console.WriteLine($"-- ${box.PriceForTheBox:F2}");
                }
            }
        }

    }


}