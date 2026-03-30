// Input

int[] inputedNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int controlNumber = int.Parse(Console.ReadLine());

// Checks

for (int i = 0; i < inputedNumbers.Length - 1; i++)
{
    int currentElement = inputedNumbers[i];

    for (int j = i + 1; j < inputedNumbers.Length; j++)
    {
        int nextRightElement = inputedNumbers[j];

        if (currentElement + nextRightElement == controlNumber)
        {
            Console.WriteLine($"{currentElement} {nextRightElement}");
            break;
        }
    }
}
