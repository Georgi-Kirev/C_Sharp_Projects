// Input

int dayOfAWeek = int.Parse(Console.ReadLine());

// Checks and Output

string[] dayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

if (dayOfAWeek > 0 && dayOfAWeek <= 7)
{
    string day = dayNames[dayOfAWeek - 1];
    Console.WriteLine(day);
}
else
{
    Console.WriteLine("Invalid day!");
}