// Input

int numN = int.Parse(Console.ReadLine());

// Checks

for (int i = 0; i <= numN; i++)
{
    int check = (int)Math.Pow(2, i);

    if (i % 2 == 0)
    {
        Console.WriteLine(check);
    }

}