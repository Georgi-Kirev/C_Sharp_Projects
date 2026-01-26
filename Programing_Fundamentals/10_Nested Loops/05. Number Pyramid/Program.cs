// Input

int numN = int.Parse(Console.ReadLine());
int startNum = 1;

for (int i = 1; startNum <= numN; i++)
{
    for (int j = 1; j <= i && startNum <= numN; j++)
    {
        Console.Write(startNum + " ");
        startNum++;
    }
    Console.WriteLine();
}
