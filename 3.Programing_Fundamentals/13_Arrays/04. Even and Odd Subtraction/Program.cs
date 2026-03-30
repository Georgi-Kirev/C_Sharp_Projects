// Input and Variables

int[] numbersFromConsole = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int Even = 0;
int Odd = 0;
// Checks

foreach (int num in numbersFromConsole)
{
    if (num % 2 == 0)
    {
        Even += num;
    }
    else if (num % 2 != 0)
    {
        Odd += num;
    }
}

// Calculation

int result = Even - Odd;

// Output

Console.WriteLine(result);