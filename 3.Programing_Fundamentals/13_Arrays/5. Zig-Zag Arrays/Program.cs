// Input

int numCycles = int.Parse(Console.ReadLine());
int[] evenCycles = new int[numCycles];
int[] oddCycles = new int[numCycles];


for (int i = 0; i < numCycles; i++)
{
    int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    if (i % 2 == 0)
    {
        evenCycles[i] = input[0];
        oddCycles[i] = input[1];
    }
    else
    {
        oddCycles[i] = input[0];
        evenCycles[i] = input[1];
    }
}

Console.WriteLine(string.Join(" ", evenCycles));
Console.WriteLine(string.Join(" ", oddCycles));