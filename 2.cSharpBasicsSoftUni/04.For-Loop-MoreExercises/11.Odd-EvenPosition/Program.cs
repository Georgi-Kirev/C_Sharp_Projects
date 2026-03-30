// Input
int n = int.Parse(Console.ReadLine());

// Integers
double OddSum = 0;
double OddMin = double.MaxValue;
double OddMax = double.MinValue;
double EvenSum = 0;
double EvenMin = double.MaxValue;
double EvenMax = double.MinValue;

// Calculations

for (int i = 1; i <= n; i++)
{
    double consoleNumbers = double.Parse(Console.ReadLine());

    if (i % 2 == 0) // Even numbers
    {
        EvenSum = consoleNumbers + EvenSum;
        if (consoleNumbers < EvenMin)
        {
            EvenMin = consoleNumbers;
        }
        if (consoleNumbers > EvenMax)
        {
            EvenMax = consoleNumbers;
        }
    }
    else if (i % 2 != 0) // Odd numbers
    {

        OddSum = consoleNumbers + OddSum;
        if (consoleNumbers < OddMin)
        {
            OddMin = consoleNumbers;
        }
        if (consoleNumbers > OddMax)
        {
            OddMax = consoleNumbers;
        }
    }
}

// Output

Console.WriteLine($"OddSum={OddSum:F2},");
if (OddMin == double.MaxValue)
    Console.WriteLine($"OddMin=No,");
else
    Console.WriteLine($"OddMin={OddMin:F2},");
if (OddMax == double.MinValue)
    Console.WriteLine($"OddMax=No,");
else
    Console.WriteLine($"OddMax={OddMax:F2},");
Console.WriteLine($"EvenSum={EvenSum:F2},");
if (EvenMin == double.MaxValue)
    Console.WriteLine($"EvenMin=No,");
else
    Console.WriteLine($"EvenMin={EvenMin:F2},");
if (EvenMax == double.MinValue)
    Console.WriteLine($"EvenMax=No");
else
    Console.WriteLine($"EvenMax={EvenMax:F2}");
