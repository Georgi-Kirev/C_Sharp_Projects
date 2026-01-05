// Input
int number = int.Parse(Console.ReadLine());

int sum = 0;
// Output
for (int i = 0; i < number; i++)
{
    int text = int.Parse(Console.ReadLine());
    sum += text;
}

Console.WriteLine(sum);