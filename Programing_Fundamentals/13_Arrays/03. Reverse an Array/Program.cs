// Input

int numbersToAdd = int.Parse(Console.ReadLine());

// Arrays

int[] actualNumbers = new int[numbersToAdd];

for (int i = 0; i < numbersToAdd; i++)
{
    actualNumbers[i] = int.Parse(Console.ReadLine());
}

// Checks and Outputs

for (int i = actualNumbers.Length - 1; i >= 0; i--)
{
    Console.Write(actualNumbers[i] + " ");
}