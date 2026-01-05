// Input
double moneyInBank = 0;

while (moneyInBank >= 0)
{
    string text = Console.ReadLine();
    if (text == "NoMoreMoney")
    {
        break;
    }
    double moneyAdd = double.Parse(text);

    if (moneyAdd <= 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    Console.WriteLine($"Increase: {moneyAdd:F2}");
    moneyInBank += moneyAdd;

}

Console.WriteLine($"Total: {moneyInBank:F2}");