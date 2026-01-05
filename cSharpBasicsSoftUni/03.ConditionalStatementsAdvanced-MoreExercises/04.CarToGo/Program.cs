// Input
double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

// Integers
double cabrio = 0;
double jeep = 0;
string classOfCar = "";
string tipeOfCar = "";
// Calculation
if (budget <= 100) //Economy Class
{
    classOfCar = ("Economy class");
    if (season == "Summer")
    {
        tipeOfCar = ("Cabrio");
        cabrio = budget * 0.35;
    }
    else if (season == "Winter")
    {
        tipeOfCar = ("Jeep");
        jeep = budget * 0.65;
    }
}
else if (budget > 100 && budget <= 500)
{
    classOfCar = ("Compact class");
    if (season == "Summer")
    {
        tipeOfCar = ("Cabrio");
        cabrio = budget * 0.45;
    }
    else if (season == "Winter")
    {
        tipeOfCar = ("Jeep");
        jeep = budget * 0.80;
    }
}
else if (budget > 500)
{
    classOfCar = ("Luxury class");
    tipeOfCar = ("Jeep");
    jeep = budget * 0.90;
}

Console.WriteLine($"{classOfCar}");
if (season == "Summer" && classOfCar != "Luxury class")
    Console.WriteLine($"{tipeOfCar} - {cabrio:F2}");
else if (season == "Winter" || classOfCar == "Luxury class")
    Console.WriteLine($"{tipeOfCar} - {jeep:F2}");