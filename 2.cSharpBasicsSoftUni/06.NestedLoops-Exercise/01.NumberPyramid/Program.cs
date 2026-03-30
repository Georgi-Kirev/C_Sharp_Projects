// Input
int n = int.Parse(Console.ReadLine());

int current = 1;
bool isBigger = false;

for (int Rows = 1; Rows <= n; Rows++)
{
    for (int Colloms = 1; Colloms <= Rows; Colloms++)
    {
        if (current > n)
        {
            isBigger = true;
            break;
        }
        Console.Write(current + " ");
        current++;
    }
    if (isBigger)
    {
        break;
    }
    Console.WriteLine();
}