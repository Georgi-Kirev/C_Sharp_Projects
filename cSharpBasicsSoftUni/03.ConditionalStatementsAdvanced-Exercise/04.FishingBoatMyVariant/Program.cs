// Input
int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int numFishers = int.Parse(Console.ReadLine());

// Spring - price 3000lv
// Summer and Autumn - 4200lv
// Winter - 2600lv
if (budget < 1 || budget > 8000) return;
else if (numFishers < 4 || numFishers > 18) return;
double finalPrice = 0;

if (season == "Spring")
{
    finalPrice = 3000;
    if (numFishers <= 6) finalPrice *= 0.90;
    else if (numFishers >= 7 && numFishers <= 11) finalPrice *= 0.85;
    else if (numFishers >= 12) finalPrice *= 0.75;
}
else if (season == "Summer" || season == "Autumn")
{
    finalPrice = 4200;
    if (numFishers <= 6) finalPrice *= 0.90;
    else if (numFishers >= 7 && numFishers <= 11) finalPrice *= 0.85;
    else if (numFishers >= 12) finalPrice *= 0.75;
}
else if (season == "Winter")
{
    finalPrice = 2600;
    if (numFishers <= 6) finalPrice *= 0.90;
    else if (numFishers >= 7 && numFishers <= 11) finalPrice *= 0.85;
    else if (numFishers >= 12) finalPrice *= 0.75;
}

if (numFishers % 2 == 0 && season != "Autumn") finalPrice *= 0.95;

double moneyLeft = budget - finalPrice;

if (budget > finalPrice) Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
else if (budget < finalPrice) Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):F2} leva.");