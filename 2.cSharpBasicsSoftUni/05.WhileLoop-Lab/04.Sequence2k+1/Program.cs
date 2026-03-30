// Input
int n = int.Parse(Console.ReadLine());
int sum = 1;
while (n >= sum)
{
    Console.WriteLine(sum);
    sum = sum * 2 + 1;
}