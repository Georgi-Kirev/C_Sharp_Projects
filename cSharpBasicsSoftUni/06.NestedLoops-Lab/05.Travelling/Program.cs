
// Inputs

while (true)
{
    string destination = Console.ReadLine();

    if (destination == "End")
    {
        break;
    }

    double neededMoney = double.Parse(Console.ReadLine());
    double savedMoney = 0;

    while (savedMoney < neededMoney)
    {
        double currentAmount = double.Parse(Console.ReadLine());
        savedMoney += currentAmount;
    }

    Console.WriteLine($"Going to {destination}!");
}
