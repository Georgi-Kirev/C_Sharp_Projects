// Input
double budget = double.Parse(Console.ReadLine());
int videos =  int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

// Calculations
double videoPrice = videos * 250;
double processorPrice = processors * (videoPrice * 0.35);
double ramPrice = ram * (videoPrice * 0.1);

double priceComponents = videoPrice + processorPrice + ramPrice;
if (videos > processors)
{
    priceComponents = priceComponents - (priceComponents * 0.15);
}

// Output

if (priceComponents <= budget)
{
    double money = budget - priceComponents;
    Console.WriteLine($"You have {money:F2} leva left!");
}
else if (priceComponents > budget)
{
    double money = Math.Abs(budget - priceComponents);
    Console.WriteLine($"Not enough money! You need {money:F2} leva more!");
}