// Input
int months = int.Parse(Console.ReadLine());

if (months < 1 || months > 100)
{
    Console.WriteLine("Invalid Number");
    return;
}
// Integers
double electricity = 0;
double water = 0;
double internet = 0;
double other = 0;

// Calculations 

for (int i = 0; i < months; i++)
{
    double bill = double.Parse(Console.ReadLine());

    if (bill < 1.00 || bill > 1000.00)
    {
        Console.WriteLine("Invalid Number");
        return;
    }

    electricity += bill;
    water = months * 20;
    internet = months * 15;
    other += (bill + 20 + 15) * 1.2;

}

double averageBill = (electricity + water + internet + other) / months;

// Output
Console.WriteLine($"Electricity: {electricity:F2} lv");
Console.WriteLine($"Water: {water:F2} lv");
Console.WriteLine($"Internet: {internet:F2} lv");
Console.WriteLine($"Other: {other:F2} lv");
Console.WriteLine($"Average: {averageBill:F2} lv");