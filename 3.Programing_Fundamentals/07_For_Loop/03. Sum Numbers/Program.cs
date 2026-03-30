// Input

int n = int.Parse(Console.ReadLine());
double numbers = 0;
for (int i = 0; i < n; i++)
{
    numbers += double.Parse(Console.ReadLine());
}

Console.WriteLine(numbers);