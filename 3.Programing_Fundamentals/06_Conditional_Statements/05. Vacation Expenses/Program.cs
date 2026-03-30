// Input

string season = Console.ReadLine();
string place = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double pricePerNight = 0;
double discount = 0;
// Checks

if (season == "Spring")
{
    discount = 0.8;
    if (place == "Hotel")
        pricePerNight = 30;
    else if (place == "Camping")
        pricePerNight = 10;
}
else if (season == "Summer")
{
    if (place == "Hotel")
        pricePerNight = 50;
    else if (place == "Camping")
        pricePerNight = 30;
}
else if (season == "Autumn")
{
    discount = 0.7;
    if (place == "Hotel")
        pricePerNight = 20;
    else if (place == "Camping")
        pricePerNight = 15;
}
else if (season == "Winter")
{
    discount = 0.9;
    if (place == "Hotel")
        pricePerNight = 40;
    else if (place == "Camping")
        pricePerNight = 10;
}

// Calculations

double expensesNoDiscount = pricePerNight * days;
double expenses = expensesNoDiscount * discount;
if (season != "Summer")
    Console.WriteLine($"{expenses:F2}");
else
    Console.WriteLine($"{expensesNoDiscount:F2}");
