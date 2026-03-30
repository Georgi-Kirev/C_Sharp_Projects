// Input

int triangleSize = int.Parse(Console.ReadLine());
string stars = "*";
// Output

for (int i = 0; i < triangleSize; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(stars);
    }
    Console.WriteLine(stars);
}