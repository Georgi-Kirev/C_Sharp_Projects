// Input
double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double priceDres = double.Parse(Console.ReadLine());

//•	Декорът за филма е на стойност 10% от бюджета. 
//•	При повече от 150 статиста, има отстъпка за облеклото на стойност 10%.

// Calculations
double decor = budget * 0.1;


if (statists >= 150)
{ 
    priceDres = priceDres - (priceDres * 0.1);
    
}
    
double statistsDres = statists * priceDres;

double endExpence = decor + statistsDres;
double moneyLeft = budget - endExpence;

// Output
if (endExpence > budget)
{
    Console.WriteLine("Not enough money!");
    double money = endExpence - budget;
    Console.WriteLine($"Wingard needs {money:F2} leva more.");
}
else if (endExpence <= budget)
{
    Console.WriteLine("Action!");
    double money = budget - endExpence;
    Console.WriteLine($"Wingard starts filming with {money:F2} leva left.");
}