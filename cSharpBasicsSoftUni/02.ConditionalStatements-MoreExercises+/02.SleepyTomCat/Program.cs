// Input
int freeDays = int.Parse(Console.ReadLine());

// Check for condition
if (freeDays < 0 || freeDays > 365)
{
    Console.WriteLine("Unreal days of the year.");
    return;
}
// Calculations
int workingDays = 365 - freeDays;
int playTime = workingDays * 63 + freeDays * 127;
int difference = Math.Abs(30000 - playTime);
int hours = difference / 60;
int minutes = difference % 60;


// Output

if  (playTime > 30000)
{
    Console.WriteLine("Tom will run away");
    Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
}
else
{
    Console.WriteLine("Tom sleeps well");
    Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
}