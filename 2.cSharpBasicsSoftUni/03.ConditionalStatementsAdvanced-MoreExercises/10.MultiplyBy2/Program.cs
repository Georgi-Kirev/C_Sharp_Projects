
double i = double.Parse(Console.ReadLine());
while (i >= 0)
{

    i = i * 2;
    Console.WriteLine($"Result: {i:F2}");
    i = double.Parse(Console.ReadLine());

}
Console.WriteLine("Negative number!");