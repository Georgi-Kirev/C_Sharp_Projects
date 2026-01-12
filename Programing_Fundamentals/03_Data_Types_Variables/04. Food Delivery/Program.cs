// Input:

int chicken = int.Parse(Console.ReadLine());
int fish = int.Parse(Console.ReadLine());
int vegetarian = int.Parse(Console.ReadLine());

// Price:

double chickenMenu = 10.35;
double fishMenu = 12.40;
double vegetarianMenu = 8.15;
double delivery = 2.50;

// Calculation:
double chickenCost = chicken * chickenMenu;
double fishCost = fish * fishMenu;
double vegetarianCost = vegetarian * vegetarianMenu;
double totalCost = chickenCost + fishCost + vegetarianCost;
double desertCost = totalCost * 0.20;

double costWithDelivery = totalCost + desertCost + delivery;

// Output:

Console.WriteLine(costWithDelivery);