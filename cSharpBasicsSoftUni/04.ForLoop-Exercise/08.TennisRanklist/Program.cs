// Input
int numOfTornaments = int.Parse(Console.ReadLine());
int points = int.Parse(Console.ReadLine());

int colectedPoints = 0;
int winCounter = 0;
// Output
for (int i = 0; i < numOfTornaments; i++)
{
    string result = Console.ReadLine();
    switch (result)
    {
        case "W":
            colectedPoints += 2000;
            winCounter++;
            break;
        case "F":
            colectedPoints += 1200;
            break;
        case "SF":
            colectedPoints += 720;
            break;
        default:
            colectedPoints += 0; // In case of unexpected input
            break;
    }
}
// Output
double points1 = points + colectedPoints;
double averagePoints = Math.Floor(colectedPoints / (double)numOfTornaments);
double percentWining = winCounter / (double)numOfTornaments * 100;
Console.WriteLine($"Final points: {points1}");
Console.WriteLine($"Average points: {averagePoints:F0}");
Console.WriteLine($"{percentWining:F2}%");
