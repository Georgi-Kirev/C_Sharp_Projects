// Input
double СкумрияЦена = double.Parse(Console.ReadLine());
double ЦацаЦена = double.Parse(Console.ReadLine());
double ПаламудИнфо = double.Parse(Console.ReadLine());
double СафридИнфо = double.Parse(Console.ReadLine());
int МидиКг = int.Parse(Console.ReadLine());
double МидиЦенаКг = 7.5;

// Calculations

double СафридЦенаКг = ЦацаЦена + ЦацаЦена * 0.8;
double СафридЦена = СафридИнфо * СафридЦенаКг;
double ПаламудЦенаКг = СкумрияЦена + СкумрияЦена * 0.6;
double ПаламудЦена = ПаламудИнфо * ПаламудЦенаКг;
double МидиЦена = МидиКг * 7.5;

double result = СафридЦена + ПаламудЦена + МидиЦена;

// Output

Console.WriteLine($"{result:F2}");
