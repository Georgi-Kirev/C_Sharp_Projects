// Input
int daysStay = int.Parse(Console.ReadLine()) - 1; // days stay == days-1 for nights stay
string tipeOfRoom = Console.ReadLine();
string review = Console.ReadLine();

// Integers
double roomForPersonPrice = 18.00;
double apartmentPrice = 25.00;
double presidentApartmentPrice = 35.00;
double totalPrice = 0;
// Calculations

// Type of room
if (tipeOfRoom == "apartment" && daysStay < 10) apartmentPrice *= 0.70; // -30% discount
else if (tipeOfRoom == "apartment" && daysStay >= 10 && daysStay <= 15) apartmentPrice *= 0.65; // -35% discount
else if (tipeOfRoom == "apartment" && daysStay > 15) apartmentPrice *= 0.50; // -50% discount

if (tipeOfRoom == "president apartment" && daysStay < 10) presidentApartmentPrice *= 0.90; // -10% discount
else if (tipeOfRoom == "president apartment" && daysStay >= 10 && daysStay <= 15) presidentApartmentPrice *= 0.85; // -15% discount
else if (tipeOfRoom == "president apartment" && daysStay > 15) presidentApartmentPrice *= 0.80; // -20% discount

// Total Price calculations
if (tipeOfRoom == "room for one person")
{
    totalPrice = roomForPersonPrice * daysStay;
}
else if (tipeOfRoom == "apartment")
{
    totalPrice = apartmentPrice * daysStay;
}
else if (tipeOfRoom == "president apartment")
{
    totalPrice = presidentApartmentPrice * daysStay;
}

// Review check
if (review == "positive") totalPrice = (totalPrice - (totalPrice * 0.75)) + totalPrice;
else totalPrice *= 0.90;

// Output

Console.WriteLine($"{totalPrice:F2}");