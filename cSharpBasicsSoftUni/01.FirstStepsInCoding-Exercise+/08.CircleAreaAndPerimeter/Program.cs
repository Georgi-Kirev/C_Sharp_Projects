// Input
double r = double.Parse(Console.ReadLine());

// Calculation

// Лице
double Area = Math.PI * r * r;
// Обиколка
double Perimetar = 2 * Math.PI * r;

// Output
Console.WriteLine($"{Area:F2}");
Console.WriteLine($"{Perimetar:F2}");
