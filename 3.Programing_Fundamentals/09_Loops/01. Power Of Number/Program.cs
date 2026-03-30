// Input

int n = int.Parse(Console.ReadLine());
int p = int.Parse(Console.ReadLine());
int sum = n;
// Calculation

for (int i = 1; i < p; i++)
{
    sum = sum * n;
}

Console.WriteLine(sum);