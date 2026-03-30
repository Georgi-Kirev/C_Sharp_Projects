// Input
double VegetablesPrice = double.Parse(Console.ReadLine());
double FruitsPrice = double.Parse(Console.ReadLine());
double VegetablesAmount = double.Parse(Console.ReadLine());
double FruitsAmount = double.Parse(Console.ReadLine());

// Calculation

double VegetablesLvPrice = VegetablesAmount * VegetablesPrice;
double FuitsLvPrice = FruitsAmount * FruitsPrice;
double PriceLv = VegetablesLvPrice + FuitsLvPrice;
double PriceEU = PriceLv / 1.94;

// Output

Console.WriteLine($"{PriceEU:F2}");