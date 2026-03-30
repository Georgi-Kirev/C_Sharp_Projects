// Input

int[] arrayInput = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int rightIndex = arrayInput.Length / 2;
int leftIndex = rightIndex - 1;

int rightNum = arrayInput[rightIndex];
int leftNum = arrayInput[leftIndex];

double result = (rightNum + leftNum) / 2.0;

// Output

Console.WriteLine($"{result:F2}");