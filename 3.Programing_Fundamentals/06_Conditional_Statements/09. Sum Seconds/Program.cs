// Input

int totalTimeInSeconds = 0;
for (int i = 0; i < 3; i++)
{
    totalTimeInSeconds += int.Parse(Console.ReadLine());
}

// Calculation

int timeInMinutes = totalTimeInSeconds / 60;
int timeInSecond = totalTimeInSeconds % 60;
Console.WriteLine($"{timeInMinutes}:{timeInSecond:D2}");