// Input
double moneyForTrip = double.Parse(Console.ReadLine());
if (moneyForTrip < 1.00 || moneyForTrip > 25000.0)
{
    Console.WriteLine("Incorrect amount of money for Trip");
}
double moneyAtHand = double.Parse(Console.ReadLine());
if (moneyAtHand < 0.00 || moneyAtHand > 25000.0)
{
    Console.WriteLine("Incorrect amount of money added!");
}
int spendingCounter = 0;
int dayPast = 0;
while (true)
{
    dayPast++;
    string action = Console.ReadLine();
    if (action != "save" && action != "spend")
    {
        Console.WriteLine("Incorrect action!");
        continue;
    }
    double money = double.Parse(Console.ReadLine());
    if (money < 0.01 || money > 25000.00)
    {
        Console.WriteLine("Incorrect amount of money is added!");
    }
    if (action == "save")
    {
        moneyAtHand += money;
        spendingCounter = 0;
    }
    if (action == "spend")
    {
        moneyAtHand -= money;
        spendingCounter++;
        if (moneyAtHand < 0)
        {
            moneyAtHand = 0;
        }
    }
    if (spendingCounter == 5)
    {
        Console.WriteLine("You can't save the money.");
        Console.WriteLine(dayPast);
        break;
    }
    if (moneyAtHand >= moneyForTrip)
    {
        Console.WriteLine($"You saved the money for {dayPast} days.");
        break;
    }

}