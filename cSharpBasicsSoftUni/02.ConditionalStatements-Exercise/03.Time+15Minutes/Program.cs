// Input
int hour = int.Parse(Console.ReadLine());
int min = int.Parse(Console.ReadLine());

// Calculation
int addMin = min + 15;

if (addMin >= 60)
{
    hour = hour + 1;
    addMin = addMin - 60 ;
}
if (hour >= 24) hour = 0;

// Output
if (addMin < 10)
Console.WriteLine($"{hour}:0{addMin}");
else Console.WriteLine($"{hour}:{addMin}");