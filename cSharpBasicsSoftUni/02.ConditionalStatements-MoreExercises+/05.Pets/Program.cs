// Input
int dayNum = int.Parse(Console.ReadLine());// days missing
double foodLeftKg = double.Parse(Console.ReadLine());// Food left in kg for eating
double foodForDog = double.Parse(Console.ReadLine());// Food left for dog in kg
double foodForCat = double.Parse(Console.ReadLine());// Food left for cat in kg
double foodForTurtle = double.Parse(Console.ReadLine());// Food left for turtle in GRAMS

// Calculation

double dogFoodNeeded = dayNum * foodForDog;
double catFoodNeeded = dayNum * foodForCat;
double turtleFoodNeeded = (dayNum * foodForTurtle)/ 1000; // from grams to kg (very possible to be 0.xx)
double totalFoodNeeded = dogFoodNeeded + catFoodNeeded + turtleFoodNeeded;

// Output
if (foodLeftKg >= totalFoodNeeded)
{
    Console.WriteLine($"{Math.Floor(foodLeftKg - totalFoodNeeded)} kilos of food left.");
}
else Console.WriteLine($"{Math.Ceiling(totalFoodNeeded - foodLeftKg)} more kilos of food are needed.");