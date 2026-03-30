// Input

int[] numberEntered = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


// Checks
if (numberEntered.Length == 1)
{
    Console.WriteLine(numberEntered[0]);
    return;
}

while (numberEntered.Length > 1)
{
    int[] result = new int[numberEntered.Length - 1];

    for (int i = 0; i < numberEntered.Length - 1; i++)
    {
        result[i] += numberEntered[i] + numberEntered[i + 1];
    }
    numberEntered = result;
}

// Output

Console.WriteLine(numberEntered[0]);