// Input
string movieTitle = Console.ReadLine()!;
string typeOfHall = Console.ReadLine()!;
int numTickets = int.Parse(Console.ReadLine()!);

// Calculation
double AStarIsBorn = 0;
double BohemianRhapsody = 0;
double GreenBook = 0;
double TheFavourite = 0;

if (typeOfHall == "normal")
{
    AStarIsBorn = 7.50;
    BohemianRhapsody = 7.35;
    GreenBook = 8.15;
    TheFavourite = 8.75;
}
else if (typeOfHall == "luxury")
{
    AStarIsBorn = 10.50;
    BohemianRhapsody = 9.45;
    GreenBook = 10.25;
    TheFavourite = 11.55;
}
else if (typeOfHall == "ultra luxury")
{
    AStarIsBorn = 13.50;
    BohemianRhapsody = 12.75;
    GreenBook = 13.25;
    TheFavourite = 13.95;
}

double totalIncome = 0;
if ("A Star Is Born" == movieTitle)
{
    totalIncome = AStarIsBorn * numTickets;
}
else if ("Bohemian Rhapsody" == movieTitle)
{
    totalIncome = BohemianRhapsody * numTickets;
}
else if ("Green Book" == movieTitle)
{
    totalIncome = GreenBook * numTickets;
}
else if ("The Favourite" == movieTitle)
{
    totalIncome = TheFavourite * numTickets;
}

// Output
Console.WriteLine($"{movieTitle} -> {totalIncome:F2} lv.");