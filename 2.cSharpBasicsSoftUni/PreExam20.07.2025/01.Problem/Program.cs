double fats = double.Parse(Console.ReadLine());
double proteins = double.Parse(Console.ReadLine());
double carbs = double.Parse(Console.ReadLine());
double totalCalories = double.Parse(Console.ReadLine());
double totalWeightWater = double.Parse(Console.ReadLine());


double caloriesFromFats = ((fats / 100) * totalCalories) / 9;
double caloriesFromProteins = (proteins / 100) * totalCalories / 4;
double caloriesFromCarbs = (carbs / 100) * totalCalories / 4;

double totalWeightFood = caloriesFromFats + caloriesFromProteins + caloriesFromCarbs;
double totalWeight = totalCalories / totalWeightFood;


double waterWeight = (totalWeight * totalWeightWater) / 100;

double foodWeight = totalWeight - waterWeight;


Console.WriteLine($"{foodWeight:F4}");