// Input
int n = int.Parse(Console.ReadLine());
double nextNumber = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());
    nextNumber += number;
}
double result = nextNumber / n;
Console.WriteLine($"{result:F2}");