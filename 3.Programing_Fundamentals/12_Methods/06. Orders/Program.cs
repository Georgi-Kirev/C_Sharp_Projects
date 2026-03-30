// Input

string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

// Output

Console.WriteLine($"{PriceForOrder(product, quantity):F2}");

// Methods

static double PriceForOrder(string product, int quantity)
{
    double price = 0;
    if (product == "coffee")
    {
        price = quantity * 1.5;
    }
    else if (product == "water")
    {
        price = quantity * 1.00;
    }
    else if (product == "coke")
    {
        price = quantity * 1.40;
    }
    else if (product == "snacks")
    {
        price = quantity * 2.00;
    }
    return price;
}