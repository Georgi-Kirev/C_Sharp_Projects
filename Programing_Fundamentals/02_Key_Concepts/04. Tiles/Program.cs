// Bathroom tile calculator application

double bathroomWidth = double.Parse(Console.ReadLine());
double bathroomLength = double.Parse(Console.ReadLine());
double tileWidth = double.Parse(Console.ReadLine());
double tileLength = double.Parse(Console.ReadLine());

double bathroomArea = bathroomWidth * bathroomLength;
double addSurplus = bathroomArea * 1.10;
double tileArea = tileWidth * tileLength;
double totalTilesNeeded = addSurplus / tileArea;
Console.WriteLine(Math.Round(totalTilesNeeded));