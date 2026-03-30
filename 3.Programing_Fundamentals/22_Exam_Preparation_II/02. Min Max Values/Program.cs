// Input

int[] readInt = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int numberN = int.Parse(Console.ReadLine());

int max = readInt[0];
int min = readInt[0];

for (int i = 0; i < numberN; i++)
{
    if (readInt[i] > max)
    {
        max = readInt[i];
    }

    if (readInt[i] < min)
    {
        min = readInt[i];
    }
}

Console.WriteLine(max);
Console.WriteLine(min);
