// Input

int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int sum = 0;
// Calculation and Print

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);