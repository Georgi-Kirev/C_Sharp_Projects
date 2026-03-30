// Deer of Santa

int daysSantaIsMissing = int.Parse(Console.ReadLine());
int leftFood = int.Parse(Console.ReadLine());  // оставената храна общо за дните, в които Дядо Коледа го няма
double foodForFirstDeer = double.Parse(Console.ReadLine()); // храна за първото еленче което консумира на ден
double foodForSecondDeer = double.Parse(Console.ReadLine());// храна за второто еленче което консумира на ден
double foodForThirdDeer = double.Parse(Console.ReadLine());// храна за третото еленче което консумира на ден

double totalFoodConsumed = (foodForFirstDeer + foodForSecondDeer + foodForThirdDeer) * daysSantaIsMissing;
double foodLeft = leftFood - totalFoodConsumed;

if (foodLeft >= 0)
{
    Console.WriteLine($"{Math.Floor(foodLeft)} kilos of food left.");
}
else
{
    foodLeft = Math.Abs(foodLeft);
    Console.WriteLine($"{Math.Ceiling(foodLeft):F0} more kilos of food are needed.");
}