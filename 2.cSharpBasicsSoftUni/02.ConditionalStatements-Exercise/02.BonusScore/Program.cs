// Input
int basePoints = int.Parse(Console.ReadLine());

double p1 = 0.0;

// Calculation
if (basePoints <= 100) p1 = 5;
else if (basePoints > 100 && basePoints <= 1000) p1 = basePoints * 0.2;
else if (basePoints > 1000) p1 = basePoints * 0.1;


if (basePoints % 2 == 0) p1 = p1 + 1;
else if (basePoints % 10 == 5)  p1 = p1 + 2;

// Output

Console.WriteLine(p1);
Console.WriteLine(p1 + basePoints);