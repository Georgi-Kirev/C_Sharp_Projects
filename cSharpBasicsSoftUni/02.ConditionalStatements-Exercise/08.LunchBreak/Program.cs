// Input
string name = Console.ReadLine();
int duration = int.Parse(Console.ReadLine());
int lunchBreak = int.Parse(Console.ReadLine());

// Calculation
double lunchTime = lunchBreak / 8.0;
double restTime = lunchBreak / 4.0;

double timeLeft = lunchBreak -lunchTime - restTime;

// Output
if (timeLeft >= duration)
{
    double movieTime = timeLeft - duration;
    Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(movieTime)} minutes free time.");
}
else
{
    double movieTime = duration - timeLeft;
    Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(movieTime)} more minutes.");
}