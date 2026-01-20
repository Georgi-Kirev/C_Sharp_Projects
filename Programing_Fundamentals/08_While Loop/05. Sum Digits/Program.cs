// Input

int numPositive = int.Parse(Console.ReadLine());
int sum = 0;

while (numPositive > 0)
{
    sum += numPositive % 10;
    numPositive /= 10;
}
Console.WriteLine(sum);