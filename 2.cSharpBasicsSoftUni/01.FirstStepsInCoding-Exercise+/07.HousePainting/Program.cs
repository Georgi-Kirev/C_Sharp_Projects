// Input
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

// Calculations

// Walls
double SqareWall = (x * x) * 2;
double SqareWallDoor = 2 * 1.2;
double SqareWallTotal = SqareWall - SqareWallDoor;

double SideWall = (x * y) * 2;
double SideWallWindow = (1.5 * 1.5) * 2;
double SideWallSurface = SideWall - SideWallWindow;

double TotalAmmountGreanPaint = (SqareWallTotal + SideWallSurface) / 3.4;

// Roof
double Roof = (x * y) * 2;
double RoofSides = 2 * (x * h / 2);
double TotalAmmountRedPaint = (Roof + RoofSides) / 4.3;

// Output
Console.WriteLine($"{TotalAmmountGreanPaint:F2}");
Console.WriteLine($"{TotalAmmountRedPaint:F2}");