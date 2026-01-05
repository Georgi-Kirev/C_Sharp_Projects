// Input
double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timeNeededFor1MSwim = double.Parse(Console.ReadLine());

// Calculation
double timeIvanToSwimDistance = distance * timeNeededFor1MSwim;
double howManyTimeInDistance = Math.Floor(distance / 15);
double waterResistance = howManyTimeInDistance * 12.5;

double timeIvan = timeIvanToSwimDistance + waterResistance;

// Output

if (timeIvan >= record)
{
    double seconds = timeIvan - record;
    Console.WriteLine($"No, he failed! He was {seconds:F2} seconds slower.");
}
else if (record > timeIvan)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {timeIvan:F2} seconds.");
}