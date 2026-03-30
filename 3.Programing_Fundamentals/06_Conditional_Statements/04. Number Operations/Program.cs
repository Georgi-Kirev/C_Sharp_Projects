// Input

double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());
string operation = Console.ReadLine();

// Calculation

if (operation == "+") Console.WriteLine($"{num1} {operation} {num2} = {(num1 + num2):F2}");
else if (operation == "-") Console.WriteLine($"{num1} {operation} {num2} = {(num1 - num2):F2}");
else if (operation == "*") Console.WriteLine($"{num1} {operation} {num2} = {(num1 * num2):F2}");
else if (operation == "/") Console.WriteLine($"{num1} {operation} {num2} = {(num1 / num2):F2}");