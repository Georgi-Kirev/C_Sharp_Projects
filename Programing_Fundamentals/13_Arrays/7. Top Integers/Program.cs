// Input

int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


for (int i = 0; i < input.Length; i++)
{
    int currentNumber = input[i];

    bool topInteger = true;

    for (int j = i + 1; j < input.Length; j++)
    {
        int nextNumber = input[j];

        if (nextNumber >= currentNumber)
        {
            topInteger = false;
            break;
        }
    }

    if (topInteger)
    {
        Console.Write(currentNumber + " ");
    }
}
