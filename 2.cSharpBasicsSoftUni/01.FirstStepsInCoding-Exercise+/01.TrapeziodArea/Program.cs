// Input

double b1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
double h  = double.Parse(Console.ReadLine());

// Calculation

double result = (b1 + b2) * h / 2;

// Output

Console.WriteLine($"{result:F2}");