// New House
// Input
string flowers = Console.ReadLine();
int numFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double rose = 5.00;
double dahlias = 3.80;
double tulips = 2.80;
double narcissus = 3.00;
double gladiolus = 2.50;
double finalPrice = 0;
// Calculations
if (flowers == "Roses")
{
    finalPrice = rose * numFlowers;

    if (numFlowers > 80)
        finalPrice *= 0.90;
}
else if (flowers == "Dahlias")
{
    finalPrice = dahlias * numFlowers;
    if (numFlowers > 90)
        finalPrice *= 0.85;
}
else if (flowers == "Tulips")
{
    finalPrice = tulips * numFlowers;
    if (numFlowers > 80)
        finalPrice *= 0.85;
}
else if (flowers == "Narcissus")
{
    finalPrice = narcissus * numFlowers;
    if (numFlowers < 120)
        finalPrice *= 1.15;
}
else if (flowers == "Gladiolus")
{
    finalPrice = gladiolus * numFlowers;
    if (numFlowers < 80)
        finalPrice *= 1.20;
}

double diff = Math.Abs(budget - finalPrice);


// Output
if (budget >= finalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {diff:F2} leva left.");
}
else if (budget <= finalPrice)
{
    Console.WriteLine($"Not enough money, you need {(diff):F2} leva more.");
}
