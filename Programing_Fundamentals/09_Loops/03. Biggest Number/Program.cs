// Input

int n = int.Parse(Console.ReadLine());
int sum = int.Parse(Console.ReadLine());
// Checks

for (int i = 1; i < n; i++)
{
    int p = int.Parse(Console.ReadLine());
    if (p >= sum)
    {
        sum = p;
    }
}

Console.WriteLine(sum);