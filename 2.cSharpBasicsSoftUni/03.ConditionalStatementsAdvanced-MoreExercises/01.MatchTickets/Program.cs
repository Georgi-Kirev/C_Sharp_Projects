// Input
double budget = double.Parse(Console.ReadLine());
string category = Console.ReadLine();
int numPeople = int.Parse(Console.ReadLine());

double priceVIP = 499.99;
double priseNormal = 249.99;
double totalTicketPrice = 0;
// Calculation
if (numPeople > 0 && numPeople <= 4)
{
    budget *= 0.25; // -75% for transport 
}
else if (numPeople >= 5 && numPeople <= 9)
{
    budget *= 0.40; // -60% for transport
}
else if (numPeople >= 10 && numPeople <= 24)
{
    budget *= 0.50; // -50% for transport
}
else if (numPeople >= 25 && numPeople <= 49)
{
    budget *= 0.60; // -40% for transport
}
else if (numPeople >= 50)
{
    budget *= 0.75; // -25% for transport
}

if (category == "VIP")
{
    totalTicketPrice = priceVIP * numPeople;
}
else if (category == "Normal")
{
    totalTicketPrice = priseNormal * numPeople;
}

double diff = Math.Abs(budget - totalTicketPrice);

if (budget >= totalTicketPrice)
{
    Console.WriteLine($"Yes! You have {diff:F2} leva left.");
}
else if (budget < totalTicketPrice)
{
    Console.WriteLine($"Not enough money! You need {diff:F2} leva.");
}

