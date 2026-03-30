// Input

int[] stockPrices = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int startingIndex = int.Parse(Console.ReadLine());
int endIndex = int.Parse(Console.ReadLine());

// Variables

double sumOfNums = 0;
int indexCount = 0;

// Calculation

for (int i = startingIndex; i <= endIndex; i++)
{
    sumOfNums += stockPrices[i];
    indexCount++;
}

// Calculation base of index

double result = (double)sumOfNums / indexCount;


// Output

Console.WriteLine($"{result:F2}");