// Input
int magnolii = int.Parse(Console.ReadLine()); // Numbers Magnolii
int ziumbiul = int.Parse(Console.ReadLine()); // Numbers Ziumbiuls
int rose = int.Parse(Console.ReadLine());
int cactus = int.Parse(Console.ReadLine());
double gift  = double.Parse(Console.ReadLine()); // Price of a gift

// Integers
double magnoliiPrice = 3.25;
double ziumbiulPrice = 4.00;
double rosePrice = 3.50;
double cactusPrice = 8.00;

// Calculations
double magnoliiTotalPrice = magnolii * magnoliiPrice;
double ziumbiulTotalPrice = ziumbiul * ziumbiulPrice;
double roseTotalPrice = rose * rosePrice;
double cactusTotalPrice = cactus * cactusPrice;
double priceNoTax = magnoliiTotalPrice + ziumbiulTotalPrice + roseTotalPrice + cactusTotalPrice;
double endPrice = priceNoTax - (priceNoTax * 0.05);
double giftPosible = endPrice - gift;
double giftNotPosible = gift - endPrice;

// Output
if (endPrice >= gift)
{
    Console.WriteLine($"She is left with {Math.Floor(giftPosible)} leva.");
}
else
{
    Console.WriteLine($"She will have to borrow {Math.Ceiling(giftNotPosible)} leva.");
}