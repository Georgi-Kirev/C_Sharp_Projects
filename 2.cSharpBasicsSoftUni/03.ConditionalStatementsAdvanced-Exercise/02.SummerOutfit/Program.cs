// Лятно облекло
// Input
int degrees = int.Parse(Console.ReadLine());
string timeDay = Console.ReadLine();
string Outfit = "";
string Shoes = "";
// Calculations

if (timeDay == "Morning")
{
    if (degrees >= 10 && degrees <= 18)
    {
        Outfit = "Sweatshirt";
        Shoes = "Sneakers";
    }
    else if (degrees > 18 && degrees <= 24)
    {
        Outfit = "Shirt";
        Shoes = "Moccasins";
    }
    else if (degrees >= 25)
    {
        Outfit = "T-Shirt";
        Shoes = "Sandals";
    }
}
else if (timeDay == "Afternoon")
{
    if (degrees >= 10 && degrees <= 18)
    {
        Outfit = "Shirt";
        Shoes = "Moccasins";
    }
    else if (degrees > 18 && degrees <= 24)
    {
        Outfit = "T-Shirt";
        Shoes = "Sandals";
    }
    else if (degrees >= 25)
    {
        Outfit = "Swim Suit";
        Shoes = "Barefoot";
    }
}
else if (timeDay == "Evening")
{
    Outfit = "Shirt";
    Shoes = "Moccasins";
}

// Output
Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");