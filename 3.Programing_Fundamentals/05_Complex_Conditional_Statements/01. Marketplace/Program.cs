// Input

string product = Console.ReadLine();
string day = Console.ReadLine();

// Check

if (day == "Weekday")
{
    if (product == "Banana")
        Console.WriteLine($"{2.50:F2}");
    else if (product == "Apple")
        Console.WriteLine($"{1.30:F2}");
    else if (product == "Kiwi")
        Console.WriteLine($"{2.20:F2}");
}
else if (day == "Weekend")
{
    if (product == "Banana")
        Console.WriteLine($"{2.70:F2}");
    else if (product == "Apple")
        Console.WriteLine($"{1.60:F2}");
    else if (product == "Kiwi")
        Console.WriteLine($"{3.00:F2}");
}