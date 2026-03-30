// Input
string fruit = Console.ReadLine();
string day = Console.ReadLine();
double num = double.Parse(Console.ReadLine());
double price = 0;

// Calculations
switch (day)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        switch (fruit)
        {
            case "banana": price = 2.50; break;
            case "apple": price = 1.20; break;
            case "orange": price = 0.85; break;
            case "grapefruit": price = 1.45; break;
            case "kiwi": price = 2.70; break;
            case "pineapple": price = 5.50; break;
            case "grapes": price = 3.85; break;
            default: Console.WriteLine("error"); break;
        }
        break;
    case "Saturday":
    case "Sunday":
        switch (fruit)
        {
            case "banana": price = 2.70; break;
            case "apple": price = 1.25; break;
            case "orange": price = 0.90; break;
            case "grapefruit": price = 1.60; break;
            case "kiwi": price = 3.00; break;
            case "pineapple": price = 5.60; break;
            case "grapes": price = 4.20; break;
            default: Console.WriteLine("error"); break;
        }
        break;
    default: Console.WriteLine("error"); break;
}

double finalPrice = price * num;

// Output
if (finalPrice > 0)
{
    Console.WriteLine($"{finalPrice:F2}");
}