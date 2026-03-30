// Input
double balance = 0;
string move = "";
while (move != "End")
{
    move = Console.ReadLine();
    if (move == "End")
    {
        Console.WriteLine($"Balance: {balance:F2}");
        break;
    }
    double money = double.Parse(move);
    if (money > 0)
    {
        Console.WriteLine($"Increase: {money:F2}");
        balance += money;
    }
    else
    {
        Console.WriteLine($"Decrease: {Math.Abs(money):F2}");
        balance -= Math.Abs(money);
    }


}

