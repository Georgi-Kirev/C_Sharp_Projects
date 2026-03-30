// Input
int Tax = int.Parse(Console.ReadLine());

// Calculations

double Sneakers = Tax -(Tax * 0.4); // -40% form Tax
double Clothing = Sneakers - (Sneakers * 0.2); // -20% from price of the Sneakers
double BasketBall = Clothing / 4; // -25% form Clothing price = 1/4
double Accessories = BasketBall / 5; // -20% from BasketBall = 1/5

double TotalPrice = Tax + Sneakers +  Clothing + BasketBall + Accessories;

// Output

Console.WriteLine($"{TotalPrice:F2}");