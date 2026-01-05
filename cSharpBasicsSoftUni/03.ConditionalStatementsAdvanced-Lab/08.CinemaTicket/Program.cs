// Input

string day = Console.ReadLine();

// Calculations

if (day == "Monday" || day == "Tuesday" || day == "Friday")
{
    Console.WriteLine("12");
}
else if (day == "Wednesday" || day == "Thursday")
{
    Console.WriteLine("14");
}
else if (day == "Saturday" || day == "Sunday")
{
    Console.WriteLine("16");
}