// Input
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());

// Integers
double result = 0;
string evenOdd = "";

// check for 0

if (operation == '/' || operation == '%')
{
    if (n1 == 0)
    {
        Console.WriteLine($"Cannot divide {n2} by zero"); return;
    }
    else if (n2 == 0)
    {
        Console.WriteLine($"Cannot divide {n1} by zero"); return;
    }
}

// base Calculations 

if (operation == '+')
{
    result = n1 + n2;
    if (result % 2 == 0)
    {
        evenOdd = " - even";
    }
    else evenOdd = " - odd";
}
else if (operation == '-')
{
    result = n1 - n2;
    if (result % 2 == 0)
    {
        evenOdd = " - even";
    }
    else evenOdd = " - odd";
}
else if (operation == '*')
{
    result = n1 * n2;
    if (result % 2 == 0)
    {
        evenOdd = " - even";
    }
    else evenOdd = " - odd";
}
else if (operation == '/')
{
    result = (double)n1 / n2;
}
else if (operation == '%')
{

    result = n1 % n2;
}

// Output

if (operation == '+' || operation == '-' || operation == '*')
{
    Console.WriteLine($"{n1} {operation} {n2} = {result}{evenOdd}");
}
else if (operation == '/')
{
    Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
}
else if (operation == '%')
{
    Console.WriteLine($"{n1} {operation} {n2} = {result}");
}