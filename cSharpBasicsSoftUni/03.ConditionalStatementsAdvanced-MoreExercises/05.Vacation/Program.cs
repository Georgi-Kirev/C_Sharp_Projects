// Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// Calculations
string whereToSleep = "";
string country = "";
double price = 0;


if (budget <= 1000)
{
    whereToSleep = "Camp";
    if (season == "Summer")
    {
        country = "Alaska";
        price = budget * 0.65;
    }
    else if (season == "Winter")
    {
        country = "Morocco";
        price = budget * 0.45;
    }
}
else if (budget > 1000 && budget <= 3000)
{
    whereToSleep = "Hut";
    if (season == "Summer")
    {
        country = "Alaska";
        price = budget * 0.80;
    }
    else if (season == "Winter")
    {
        country = "Morocco";
        price = budget * 0.60;
    }
}
else if (budget > 3000)
{
    whereToSleep = "Hotel";
    if (season == "Summer")
    {
        country = "Alaska";
        price = budget * 0.90;
    }
    else if (season == "Winter")
    {
        country = "Morocco";
        price = budget * 0.90;
    }
}

Console.WriteLine($"{country} - {whereToSleep} - {price:F2}");

