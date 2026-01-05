// Input
string season = Console.ReadLine();
double kmPerMonth = double.Parse(Console.ReadLine());

double salary = 0;

// Calcualtions
if (kmPerMonth <= 5000)
{
    if (season == "Spring" || season == "Autumn")
    { salary = 0.75 * kmPerMonth; }
    else if (season == "Summer")
    { salary = 0.90 * kmPerMonth; }
    else if (season == "Winter")
    { salary = 1.05 * kmPerMonth; }
}
else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
{
    if (season == "Spring" || season == "Autumn")
    { salary = 0.95 * kmPerMonth; }
    else if (season == "Summer")
    { salary = 1.10 * kmPerMonth; }
    else if (season == "Winter")
    { salary = 1.25 * kmPerMonth; }
}
else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
{
    salary = 1.45 * kmPerMonth;
}

salary = salary * 4;
salary = salary * 0.90;
Console.WriteLine($"{salary:F2}");