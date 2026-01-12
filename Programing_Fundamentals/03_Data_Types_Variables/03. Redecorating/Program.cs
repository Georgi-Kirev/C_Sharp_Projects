
// Input:
double requiredNylon = double.Parse(Console.ReadLine());
double requiredPaint = double.Parse(Console.ReadLine());
double quantityThinner = double.Parse(Console.ReadLine());
double workHours = double.Parse(Console.ReadLine());

// Constant:
double nylonPrice = 1.50;
double paintPrice = 14.50;
double thinnerPrice = 5.00;
double bagAmount = 0.40;
// Calculation:

double nylonAmount = (requiredNylon + 2) * nylonPrice;
double paintAmount = (requiredPaint * 1.10) * paintPrice;
double thinnerAmount = quantityThinner * thinnerPrice;

double totalAmount = nylonAmount + paintAmount + thinnerAmount + bagAmount;
double craftsmanSalary = (totalAmount * 0.30) * workHours;
double totalCost = totalAmount + craftsmanSalary;

// Output:

Console.WriteLine($"{totalCost}");

