// Input
int n = int.Parse(Console.ReadLine());

// Output
for (int i = 0; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(Math.Pow(2, i));
    }
}