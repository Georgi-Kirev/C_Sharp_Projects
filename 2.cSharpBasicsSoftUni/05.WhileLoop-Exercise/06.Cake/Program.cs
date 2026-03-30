// Input
int with = int.Parse(Console.ReadLine());
int hight = int.Parse(Console.ReadLine());
if (with < 1 || hight < 1 || with > 1000 || hight > 1000)
    Console.WriteLine("Incorrect dimensions!");

int totalPieces = with * hight;

while (true)
{
    string stop = Console.ReadLine();
    if (stop == "STOP")
    {
        Console.WriteLine($"{totalPieces} pieces are left.");
        break;
    }
    int pieces = int.Parse(stop);
    totalPieces -= pieces;
    if (totalPieces <= 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
        break;
    }
}