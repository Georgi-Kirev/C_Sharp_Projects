// Input

double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
double num3 = double.Parse(Console.ReadLine());

// Checks
int points = 0;
if (num1 < 0) points++;
if (num2 < 0) points++;
if (num3 < 0) points++;

if (num1 == 0 || num2 == 0 || num3 == 0) Console.WriteLine("zero");
else if (points % 2 == 0) Console.WriteLine("positive");
else if (points % 2 == 1) Console.WriteLine("negative");
