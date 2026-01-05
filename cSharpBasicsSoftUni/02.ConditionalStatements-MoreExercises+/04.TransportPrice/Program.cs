// Input
double n = double.Parse(Console.ReadLine()); // Брой километри
string dayNight = Console.ReadLine();        // Ден ли е нощ ли е 

// Integers

// Taxi
double startPriceTaxi = 0.70;
double dayPriceTaxi = 0.79;
double nightPriceTaxi = 0.90;

// Bus
double dayNightBus = 0.09; // Може да се използва ако разстоянието е минимум 20км

// Train
double dayNightTrain = 0.06; // Може да се използва ако разстоянието е минимум 100км

// Calculations
double dayTaxiCost = startPriceTaxi + (dayPriceTaxi * n);
double nightTaxiCost = startPriceTaxi + (nightPriceTaxi * n);
double BusCost = n * dayNightBus;
double TrainCost = n * dayNightTrain;

// Output

if (dayNight == "day" )
{
    if (n >= 100)
        Console.WriteLine($"{TrainCost:F2}");
    else if (n >= 20)
        Console.WriteLine($"{BusCost:F2}");
    else Console.WriteLine($"{dayTaxiCost:F2}");
}
else if (dayNight == "night")
{
    if (n >= 100)
        Console.WriteLine($"{TrainCost:F2}");
    else if (n >= 20)
        Console.WriteLine($"{BusCost:F2}");
    else Console.WriteLine($"{nightTaxiCost:F2}");
}