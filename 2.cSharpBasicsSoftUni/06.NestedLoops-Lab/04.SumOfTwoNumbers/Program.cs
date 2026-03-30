// Input
int n = int.Parse(Console.ReadLine());
if (n < 1 || n > 999) Console.WriteLine("Wrong number!");
int x = int.Parse(Console.ReadLine());
if (x > 1000) Console.WriteLine("Wrong number!");
int y = int.Parse(Console.ReadLine());
if (y < 1 || y > 10000) Console.WriteLine("Wrong number!");
int counter = 0;
bool isCombinations = false;

for (int x1 = n; x1 <= x; x1++)
{
    for (int v2 = n; v2 <= x; v2++)
    {
        int sum = x1 + v2;
        counter++;
        if (sum == y)
        {
            Console.WriteLine($"Combination N:{counter} ({x1} + {v2} = {y})");
            isCombinations = true;
            break;
        }

    }

    if (isCombinations)
    {
        break;
    }
}
if (isCombinations == false)
    Console.WriteLine($"{counter} combinations - neither equals {y}");