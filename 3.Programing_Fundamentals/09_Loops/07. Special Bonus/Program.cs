// Input

int stop = int.Parse(Console.ReadLine());
int N = 0;
double result = 0;
// Checks

while (N != stop)
{
    if (N != stop)
    {
        result = N + (N * 0.2);
    }
    N = int.Parse(Console.ReadLine());

}

Console.WriteLine(result);