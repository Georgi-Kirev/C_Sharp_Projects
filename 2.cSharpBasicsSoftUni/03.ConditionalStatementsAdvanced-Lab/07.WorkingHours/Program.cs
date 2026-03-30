// Input
int hourOfDay = int.Parse(Console.ReadLine());
string dayWeek = Console.ReadLine();

// Calculations

if (hourOfDay >= 10 && hourOfDay <= 18)
{
    if (dayWeek == "Monday" || dayWeek == "Tuesday" || dayWeek == "Wednesday" || dayWeek == "Thursday" || dayWeek == "Friday" || dayWeek == "Saturday")
    {
        Console.WriteLine("open");
    }
    else if (dayWeek == "Sunday")
    {
        Console.WriteLine("closed");
    }
}
else
{
    Console.WriteLine("closed");
}
