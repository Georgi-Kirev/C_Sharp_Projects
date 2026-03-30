// Input
double budget = double.Parse(Console.ReadLine());
int numPeople = int.Parse(Console.ReadLine());
double pricePerPersonClothes = double.Parse(Console.ReadLine());

// Calculation
double totalClothesCost = numPeople * pricePerPersonClothes;
if (numPeople > 150)
{
    totalClothesCost *= 0.90; // 10% discount for more than 150 people
}
double decorCost = budget * 0.10;
double totalCost = totalClothesCost + decorCost;

// Output
if (totalCost <= budget)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget - totalCost:F2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {totalCost - budget:F2} leva more.");
}