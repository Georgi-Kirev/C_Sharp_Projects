// Input
int with = int.Parse(Console.ReadLine());
int depth = int.Parse(Console.ReadLine());
int hight = int.Parse(Console.ReadLine());

if (with < 1 || depth < 1 || hight < 1 || with > 1000 || depth > 1000 || hight > 1000)
    Console.WriteLine("Incorrect number");
int totalDimentions = with * depth * hight;

while (true)
{
    string done = Console.ReadLine();
    if (done == "Done")
    {
        Console.WriteLine($"{totalDimentions} Cubic meters left.");
        break;
    }
    int box = int.Parse(done);
    totalDimentions -= box;
    if (totalDimentions <= 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(totalDimentions)} Cubic meters more.");
        break;
    }
}
