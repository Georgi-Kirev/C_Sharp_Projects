// Input

int N = int.Parse(Console.ReadLine());
int start = 1;
// Checks

while (N >= start)
{
    Console.WriteLine(start);
    start = (start * 2) + 1;

}