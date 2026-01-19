// Input

int n = int.Parse(Console.ReadLine());
int total = 0;
// Calculations

for (int i = 1; i < n + 1; i++)
{
    total += i;
}

Console.WriteLine(total);