// Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// Calculations
string destination = "";
string stay = "";
// destination
if (budget <= 100)
{
    destination = "Bulgaria";
}
else if (budget <= 1000)
{
    destination = "Balkans";
}
else if (budget > 1000)
{
    destination = "Europe";
}

// money spend
if (season == "summer" && destination == "Bulgaria")
{
    budget = budget - budget * 0.70; // -30% money spend
}
else if (season == "winter" && destination == "Bulgaria")
{
    budget = budget - budget * 0.30; // -70% money spend
}

if (season == "summer" && destination == "Balkans")
{
    budget = budget - budget * 0.60; // -40% money spend
}
else if (season == "winter" && destination == "Balkans")
{
    budget = budget - budget * 0.20; // -80% money spend
}

if ((season == "summer" || season == "winter") && destination == "Europe")
{
    budget = budget - budget * 0.10; // -90% money spend
}

// where to stay
if (season == "summer" && destination != "Europe")
{
    stay = "Camp";
}
else
{
    stay = "Hotel";
}

// Output

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{stay} - {budget:F2}");