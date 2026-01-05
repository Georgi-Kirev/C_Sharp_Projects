// Input
int hourExam = int.Parse(Console.ReadLine());
int minExam = int.Parse(Console.ReadLine());
int hourArrival = int.Parse(Console.ReadLine());
int minArrival = int.Parse(Console.ReadLine());

// Calculations

int examTotalMinutes = hourExam * 60 + minExam; // Total minutes for time of exam          570 min
int arrivalTotalMinutes = hourArrival * 60 + minArrival; // Total minutes for arrival time 620 min
int diff = examTotalMinutes - arrivalTotalMinutes;

if (diff < 0)
{   // late 
    int minutesTotalLate = Math.Abs(diff);
    int hourLate = minutesTotalLate / 60;
    int minutesLate = minutesTotalLate % 60;

    Console.WriteLine("Late");
    if (hourLate == 0)
    {
        Console.WriteLine($"{minutesLate} minutes after the start");
    }
    else Console.WriteLine($"{hourLate}:{minutesLate:D2} hours after the start");

}
else if (diff >= 0 && diff <= 30)
{   // On time or early
    Console.WriteLine($"On time");

    if (diff > 0)
    {
        Console.WriteLine($"{diff} minutes before the start");
    }

}
else if (diff > 30)
{   // Early
    Console.WriteLine("Early");

    int hourEarly = diff / 60;
    int minutesEarly = diff % 60;

    if (hourEarly == 0)
    {
        Console.WriteLine($"{diff} minutes before the start");
    }
    else
    {
        Console.WriteLine($"{hourEarly}:{minutesEarly:D2} hours before the start");
    }

}