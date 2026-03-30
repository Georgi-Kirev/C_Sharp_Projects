//Input
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int countOfFisherman = int.Parse(Console.ReadLine());

// Calcualtions
double priceForBoat = 0;

if (season == "Spring")
{
    priceForBoat = 3000;
}
else if (season == "Summer")
{
    priceForBoat = 4200;
}
else if (season == "Autumn")
{
    priceForBoat = 4200;
}
else if (season == "Winter")
{
    priceForBoat = 2600;
}

if (countOfFisherman <= 6)
{
    priceForBoat *= 0.90;  // -10% discont
}
else if (countOfFisherman >= 7 && countOfFisherman <= 11)
{
    priceForBoat *= 0.85;  // -15% discount
}
else if (countOfFisherman >= 12)
{
    priceForBoat *= 0.75;  // -25% discount
}

if (countOfFisherman % 2 == 0 && season != "Autumn")
{
    priceForBoat *= 0.95; // -5% doiscount
}
double diff = Math.Abs(budget - priceForBoat);

if (budget >= priceForBoat)
    Console.WriteLine($"Yes! You have {diff:F2} leva left.");
else
    Console.WriteLine($"Not enough money! You need {diff:F2} leva.");