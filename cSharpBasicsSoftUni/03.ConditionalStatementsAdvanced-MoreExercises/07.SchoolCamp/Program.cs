// Input
string season = Console.ReadLine();
string group = Console.ReadLine();
int numOfStudents = int.Parse(Console.ReadLine());
int nights = int.Parse(Console.ReadLine());

// Calculations
string sport = "";
double price = 0;

if (season == "Winter")
{
    if (group == "boys" || group == "girls")
    {
        price = numOfStudents * 9.60 * nights;
    }
    else if (group == "mixed")
    {
        price = numOfStudents * 10 * nights;
    }
}
else if (season == "Spring")
{
    if (group == "boys" || group == "girls")
    {
        price = numOfStudents * 7.20 * nights;
    }
    else if (group == "mixed")
    {
        price = numOfStudents * 9.50 * nights;
    }
}
else if (season == "Summer")
{
    if (group == "boys" || group == "girls")
    {
        price = numOfStudents * 15 * nights;
    }
    else if (group == "mixed")
    {
        price = numOfStudents * 20 * nights;
    }
}

if (numOfStudents >= 50) { price *= 0.50; }
else if (numOfStudents >= 20 && numOfStudents < 50) { price *= 0.85; }
else if (numOfStudents >= 10 && numOfStudents < 20) { price *= 0.95; }

if (group == "girls" && season == "Winter")
    sport = "Gymnastics";
else if (group == "girls" && season == "Spring")
    sport = "Athletics";
else if (group == "girls" && season == "Summer")
    sport = "Volleyball";

if (group == "boys" && season == "Winter")
    sport = "Judo";
else if (group == "boys" && season == "Spring")
    sport = "Tennis";
else if (group == "boys" && season == "Summer")
    sport = "Football";

if (group == "mixed" && season == "Winter")
    sport = "Ski";
else if (group == "mixed" && season == "Spring")
    sport = "Cycling";
else if (group == "mixed" && season == "Summer")
    sport = "Swimming";

Console.WriteLine($"{sport} {price:F2} lv.");