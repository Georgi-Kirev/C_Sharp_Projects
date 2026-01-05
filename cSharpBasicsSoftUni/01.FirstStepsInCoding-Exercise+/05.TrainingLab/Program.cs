// Input
double w = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

// Calculation
double WW = w * 100; //Превръщане от метри в см
double HW = h * 100; //Превръщане от метри в см

double ROW = HW - 100;// Коридор ширина
int NumRow = (int)ROW / 70;
int NumCol = (int)WW / 120;
int NumWork = NumCol * NumRow - 3;

// Output

Console.WriteLine(NumWork);

// КОДА ДОЛУ РАБОТИ НО НЕ Е ПО ИЗИСКВАНЕТО НА ЗАДАЧАТА

/*
// Input
double w = double.Parse(Console.ReadLine());
double h = double.Parse(Console.ReadLine());

// Calculation
double WW = w * 100;
double HW = h * 100;
// квадратура
double AllSpace = WW * HW;
// коридор
double walkway = w * 100;
// Вход и размера на 1 работно место
double Entrance = 70 * 120;
// катедра
double WorkingSpace = 160 * 120;

double OcupyedSpace = AllSpace - walkway - Entrance - WorkingSpace;
int TotalSpaces = (int)((int)OcupyedSpace - Entrance);
int Result = TotalSpaces / 10000;
// Output

Console.WriteLine(Result);
*/