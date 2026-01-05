// Best Player
string input = Console.ReadLine();
string bestPlayer = "";
int maxGoals = 0;

while (input != "END")
{
    int goals = int.Parse(Console.ReadLine());

    if (goals > maxGoals)
    {
        maxGoals = goals;
        bestPlayer = input;
    }
    if (maxGoals >= 10)
    {
        break;
    }
    input = Console.ReadLine();
}


Console.WriteLine($"{bestPlayer} is the best player!");
if (maxGoals >= 3)
{
    Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
}
else
{
    Console.WriteLine($"He has scored {maxGoals} goals.");
}
