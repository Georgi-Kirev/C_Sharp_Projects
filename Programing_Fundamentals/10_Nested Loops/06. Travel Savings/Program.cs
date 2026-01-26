// Input

string destination = Console.ReadLine();
double expenseForDestination = double.Parse(Console.ReadLine());
double moneyColected = 0;
string moneySaved = "";
// Checks

while (moneySaved != "End")
{
    if (destination == "")
    {
        destination = Console.ReadLine();
        if (destination == "End") break;
        expenseForDestination = double.Parse(Console.ReadLine());
    }
    moneySaved = Console.ReadLine();
    if (moneySaved == "End")
    {
        break;
    }

    moneyColected += double.Parse(moneySaved);
    if (moneyColected < expenseForDestination)
    {
        Console.WriteLine($"Collected: {moneyColected:F2}");
    }
    else
    {
        Console.WriteLine($"Collected: {moneyColected:F2}");
        Console.WriteLine($"Going to {destination}!");
        moneyColected = 0;
        destination = "";
        expenseForDestination = 0;
    }
}