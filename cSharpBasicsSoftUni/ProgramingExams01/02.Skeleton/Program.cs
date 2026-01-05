// Input
int MinControl = int.Parse(Console.ReadLine());
int SecondsControl = int.Parse(Console.ReadLine());
double LenghtOfTrack = double.Parse(Console.ReadLine());
int SecondsFor100M = int.Parse(Console.ReadLine());

// Calculation
int ControlInSeconds = MinControl * 60 + SecondsControl;
double HowManyTimeWillDecrease = LenghtOfTrack / 120;
double TotalTimeReduced = HowManyTimeWillDecrease * 2.5;
double MartinsTime = (LenghtOfTrack / 100) * SecondsFor100M - TotalTimeReduced;
double SecondsBack = MartinsTime - ControlInSeconds;

if (ControlInSeconds >= MartinsTime)
{
    Console.WriteLine("Marin Bangiev won an Olympic quota!");
    Console.WriteLine($"His time is {MartinsTime:F3}.");
}
else
{
    Console.WriteLine($"No, Marin failed! He was {SecondsBack:F3} second slower.");
}