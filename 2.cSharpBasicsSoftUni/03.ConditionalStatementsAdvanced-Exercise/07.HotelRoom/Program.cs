// Input
string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

// Integers
double studioPrice = 0;
double apartmentPrice = 0;

// Calculations

if (month == "May" || month == "October")
{
    studioPrice = 50;
    apartmentPrice = 65;
}
else if (month == "June" || month == "September")
{
    studioPrice = 75.20;
    apartmentPrice = 68.70;
}
else if (month == "July" || month == "August")
{
    studioPrice = 76;
    apartmentPrice = 77;
}

// discounts

if ((month == "May" || month == "October") && nights > 14)
{
    studioPrice *= 0.70; // -30% discount
}
else if ((month == "May" || month == "October") && nights > 7)
{
    studioPrice *= 0.95; // -5% discount
}
else if ((month == "June" || month == "September") && nights > 14)
{
    studioPrice *= 0.80; // -20% discount
}

if (nights > 14)
{
    apartmentPrice *= 0.90; // -10% discount
}

double studioFinalPrice = nights * studioPrice;
double apartmentFinalPrice = nights * apartmentPrice;

// Output

Console.WriteLine($"Apartment: {apartmentFinalPrice:F2} lv.");
Console.WriteLine($"Studio: {studioFinalPrice:F2} lv.");