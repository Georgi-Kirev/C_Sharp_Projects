// Input
double x = double.Parse(Console.ReadLine());         //квадратура на лозето
double y = double.Parse(Console.ReadLine());         //грозде за 1кв.м.
double z = double.Parse(Console.ReadLine());         //нужни литри вино
int workersNum = int.Parse(Console.ReadLine());      //брой работници

// Integers
double overProduct = 0;
double wineForWorkers = 0;
double underProduction = 0;
// Calculation
double totalGrape = x * y;
double wine = (0.4 * totalGrape) / 2.5;

if (wine >= z)
{
    overProduct = wine - z;
    wineForWorkers = overProduct / workersNum;
}
else
{ 
    underProduction = z - wine;
}    
    

// Output

if (wine < z)
{
    Console.WriteLine($"It will be a tough winter! More {Math.Floor(underProduction)} liters wine needed.");
}
else
{
    Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
    Console.WriteLine($"{Math.Ceiling(overProduct)} liters left -> {Math.Ceiling(wineForWorkers)} liters per person.");
}