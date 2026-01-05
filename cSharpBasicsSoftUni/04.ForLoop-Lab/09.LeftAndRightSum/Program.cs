// Input
int n = int.Parse(Console.ReadLine());
int leftSum = 0;
int rightSum = 0;
// Output
for (int i = 0; i < 2 * n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (i < n)
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
    Console.WriteLine($"Yes, sum = {rightSum}");
}
else
{
    Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightSum)}");
}