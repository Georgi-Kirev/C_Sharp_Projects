// Input
string stage = Console.ReadLine();
string ticketType = Console.ReadLine();
int ticketCount = int.Parse(Console.ReadLine());
char picture = char.Parse(Console.ReadLine());

// Variables
double ticketPrice = 0;
int picturePricePerPerson = (picture == 'Y') ? 40 : 0;

// Calculation
if (stage == "Quarter final")
{
    if (ticketType == "Standard") ticketPrice = 55.50;
    else if (ticketType == "Premium") ticketPrice = 105.20;
    else if (ticketType == "VIP") ticketPrice = 118.90;
}
else if (stage == "Semi final")
{
    if (ticketType == "Standard") ticketPrice = 75.88;
    else if (ticketType == "Premium") ticketPrice = 125.22;
    else if (ticketType == "VIP") ticketPrice = 300.40;
}
else if (stage == "Final")
{
    if (ticketType == "Standard") ticketPrice = 110.10;
    else if (ticketType == "Premium") ticketPrice = 160.66;
    else if (ticketType == "VIP") ticketPrice = 400;
}
else { return; }

// Total Price Calculation
if ( ticketCount >0 || ticketCount < 31) 
{
    ticketCount = ticketCount;
}
else { return; }

double totalPrice = ticketPrice * ticketCount; // Цялостната цена...

// Applying discount

if  (totalPrice > 4000)
{
    totalPrice *= 0.75; // 25% discount
    picturePricePerPerson = 0; // free picture
}
else if (totalPrice > 2500)
{
    totalPrice *= 0.90; // 10% discount
}

// Add picture price if it is possible

totalPrice += picturePricePerPerson * ticketCount;

// Output

Console.WriteLine($"{totalPrice:F2}");