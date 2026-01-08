// · Package of pens - 5.80 lv.
//· Package of markers - 7.20 lv.
//· Board cleaner - 1.20 BGN (per liter)

// Input:
int numbersOfPens = int.Parse(Console.ReadLine());
int numbersOfMarkers = int.Parse(Console.ReadLine());
int litersOfCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

// Constant variables:
double pensPer = 5.8;
double markersPer = 7.2;
double cleanerPer = 1.2;

// Calculation:
double pensTotal = numbersOfPens * pensPer;
double markersTotal = numbersOfMarkers * markersPer;
double cleanersTotal = litersOfCleaner * cleanerPer;
double totalPrice = pensTotal + markersTotal + cleanersTotal;
double priceAfterDiscount = totalPrice - (totalPrice * discount / 100);

// Output:

Console.WriteLine(priceAfterDiscount);
