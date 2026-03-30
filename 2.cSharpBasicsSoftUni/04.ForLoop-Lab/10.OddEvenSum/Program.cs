// Input
int n = int.Parse(Console.ReadLine());
int leftSum = 0;
int rightSum = 0;
// Output
for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        // Left sum
        leftSum += number;
    }
    else
    {
        // Right sum
        rightSum += number;
    }
}


if (leftSum == rightSum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {leftSum}");
}
else
{
    int sum = Math.Abs(leftSum - rightSum);
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {sum}");
}