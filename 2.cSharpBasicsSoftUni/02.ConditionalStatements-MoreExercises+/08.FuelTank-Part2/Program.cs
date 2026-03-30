// Input
using System;

string fuelTipe = Console.ReadLine();
double fuelAmmount = double.Parse(Console.ReadLine());
string card = Console.ReadLine(); // can be Yes or No

// Integer
double gasoline = 2.22; // 0.18/l if have card
double diesel = 2.33;   // 0.12/l if have card
double gas = 0.93;      // 0.08/l if have card

// Calculation
if (card == "Yes")
{
    gasoline -= 0.18;
    diesel -= 0.12;
    gas -= 0.08;
}

double gasolineBought = fuelAmmount * gasoline;
double dieselBought = fuelAmmount * diesel;
double gasBought = fuelAmmount * gas;

if (fuelAmmount > 25)
{
    gasolineBought = gasolineBought - (gasolineBought * 0.10);
    dieselBought = dieselBought - (dieselBought * 0.10);
    gasBought = gasBought - (gasBought * 0.10);
}
else if (fuelAmmount >= 20 && fuelAmmount <= 25)
{
    gasolineBought = gasolineBought - (gasolineBought * 0.08);
    dieselBought = dieselBought - (dieselBought * 0.08);
    gasBought = gasBought - (gasBought * 0.08);
}

// Output
if (fuelTipe == "Gasoline")
{
   Console.WriteLine($"{gasolineBought:F2} lv.");
}
else if (fuelTipe == "Diesel")
{
    Console.WriteLine($"{dieselBought:F2} lv.");
}
else if (fuelTipe == "Gas")
{
    Console.WriteLine($"{gasBought:F2} lv.");
}