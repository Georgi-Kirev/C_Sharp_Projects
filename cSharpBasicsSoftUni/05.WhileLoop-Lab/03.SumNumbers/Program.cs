// Input
int numCycles = int.Parse(Console.ReadLine());
int sum = 0;

while (numCycles > sum)
{
    int newNum = int.Parse(Console.ReadLine());
    sum += newNum;
}

Console.WriteLine(sum);
