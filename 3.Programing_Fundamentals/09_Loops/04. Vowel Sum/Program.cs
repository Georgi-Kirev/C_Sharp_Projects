// Input

int N = int.Parse(Console.ReadLine());
int sum = 0;
// Checks

for (int i = 0; i < N; i++)
{
    char K = char.Parse(Console.ReadLine());

    if (K == 'a')
    {
        sum += 1;
    }
    else if (K == 'e')
    {
        sum += 2;
    }
    else if (K == 'i')
    {
        sum += 3;
    }
    else if (K == 'o')
    {
        sum += 4;
    }
    else if (K == 'u')
    {
        sum += 5;
    }
}
Console.WriteLine(sum);