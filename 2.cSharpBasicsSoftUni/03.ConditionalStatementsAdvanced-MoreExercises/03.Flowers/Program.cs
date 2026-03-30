// Input
int chrysanthemums = int.Parse(Console.ReadLine());
int rose = int.Parse(Console.ReadLine());
int tulips = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
char holyDay = char.Parse(Console.ReadLine());
// +2lv for preparing the flowers always
// Integers
double chrysanthemumsPrice = 0;
double rosePrice = 0;
double tulipsPrice = 0;

// Calculations

if (season == "Spring" || season == "Summer")
{
    chrysanthemumsPrice = 2.00;
    rosePrice = 4.10;
    tulipsPrice = 2.50;

}
else if (season == "Autumn" || season == "Winter")
{
    chrysanthemumsPrice = 3.75;
    rosePrice = 4.50;
    tulipsPrice = 4.15;
}

if (holyDay == 'Y')
{
    chrysanthemumsPrice *= 1.15;
    rosePrice *= 1.15;
    tulipsPrice *= 1.15;
}

double finalPrice = chrysanthemums * chrysanthemumsPrice + rose * rosePrice + tulips * tulipsPrice;

if (season == "Spring" && tulips > 7) finalPrice *= 0.95; // -5% discount
else if (season == "Winter" && rose >= 10) finalPrice *= 0.90; // -10% discount

int numFlowers = chrysanthemums + rose + tulips;
if (numFlowers > 20) finalPrice *= 0.80;

finalPrice += 2;

Console.WriteLine($"{finalPrice:F2}");