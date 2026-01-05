// Input
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());

// Calculations
double minimumX = Math.Min(x1, x2);
double maximumX = Math.Max(x1, x2);
double minimumY = Math.Min(y1, y2);
double maximumY = Math.Max(y1, y2);

bool leftOrRightX = (x == minimumX || x == maximumX) && (y >= minimumY && y <= maximumY);
bool rightOrLeftY = (y == minimumY || y == maximumY) && (x >= minimumX && x <= maximumX);


if (leftOrRightX || rightOrLeftY)
{
    Console.WriteLine("Border");
}
else
{
    Console.WriteLine("Inside / Outside");
}