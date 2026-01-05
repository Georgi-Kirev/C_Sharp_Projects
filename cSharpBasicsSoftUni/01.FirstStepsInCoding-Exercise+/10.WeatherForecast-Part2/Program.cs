// Input
double Degrees = double.Parse(Console.ReadLine());

// Calculation

if (Degrees >= 26.00 && Degrees <= 35.00)
{
    Console.WriteLine("Hot");
}
else if (Degrees >= 20.1 && Degrees <= 25.9)
{
    Console.WriteLine("Warm");
}
else if (Degrees >= 15.00 && Degrees <= 20.00)
{
    Console.WriteLine("Mild");
}
else if (Degrees >= 12.00 && Degrees <= 14.9)
{
    Console.WriteLine("Cool");
}
else if (Degrees >= 5.00 && Degrees <= 11.9)
{
    Console.WriteLine("Cold");
}
else
    Console.WriteLine("unknown");