// Input

int N = int.Parse(Console.ReadLine());
double two = 0;
double three = 0;
double four = 0;

// Checks

for (int i = 0; i < N; i++)
{
    int n = int.Parse(Console.ReadLine());

    if (n % 2 == 0)
    {
        two++;
    }
    if (n % 3 == 0)
    {
        three++;
    }
    if (n % 4 == 0)
    {
        four++;
    }
}

Console.WriteLine($"{(two / N) * 100:F2}%");
Console.WriteLine($"{(three / N) * 100:F2}%");
Console.WriteLine($"{(four / N) * 100:F2}%");