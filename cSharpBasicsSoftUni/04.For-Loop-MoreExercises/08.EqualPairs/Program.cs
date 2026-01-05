
int numDoubles = int.Parse(Console.ReadLine());

int previousSum = 0;
int maxDiff = 0;
bool firstPair = true;

for (int i = 0; i < numDoubles; i++)
{
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    int currentSum = num1 + num2;

    if (firstPair)
    {
        previousSum = currentSum;
        firstPair = false;
    }
    else
    {
        int diff = Math.Abs(currentSum - previousSum);
        if (diff > maxDiff)
        {
            maxDiff = diff;
        }

        previousSum = currentSum;
    }
}

if (maxDiff == 0)
{
    Console.WriteLine($"Yes, value={previousSum}");
}
else
{
    Console.WriteLine($"No, maxdiff={maxDiff}");
}
