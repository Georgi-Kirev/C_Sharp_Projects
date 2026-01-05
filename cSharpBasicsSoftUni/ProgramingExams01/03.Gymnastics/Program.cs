// Input
string Country = Console.ReadLine();
string Tool = Console.ReadLine();
double MaxScore = 20;
// Calculation
// Countries = Russia,Bulgaria,Italy;
// Competition = ribbon,hoop,rope;

double RussiaRibbon = 9.100 + 9.400;
double RussiaHoop = 9.300 + 9.800;
double RussiaRope = 9.600 + 9.000;

double BulgariaRibbon = 9.600 + 9.400;
double BulgariaHoop = 9.550 + 9.750;
double BulgariaRope = 9.500 + 9.400;

double ItalyRibbon = 9.200 + 9.500;
double ItalyHoop = 9.450 + 9.350;
double ItalyRope = 9.700 + 9.150;

double score = 0;

if (Country == "Russia")
{
    if (Tool == "ribbon") score = RussiaRibbon;
    else if (Tool == "hoop") score = RussiaHoop;
    else if (Tool == "rope") score = RussiaRope;
}
else if (Country == "Bulgaria")
{
    if (Tool == "ribbon") score = BulgariaRibbon;
    else if (Tool == "hoop") score = BulgariaHoop;
    else if (Tool == "rope") score = BulgariaRope;
}
else if (Country == "Italy")
{
    if (Tool == "ribbon") score = ItalyRibbon;
    else if (Tool == "hoop") score = ItalyHoop;
    else if (Tool == "rope") score = ItalyRope;
}

double Diff = MaxScore - score;
double Percent = (Diff / MaxScore) * 100;

// Output

Console.WriteLine($"The team of {Country} get {score:F3} on {Tool}.");
Console.WriteLine($"{Percent:F2}%");