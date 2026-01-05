// Input
int n = int.Parse(Console.ReadLine());

// Output
if (n < 1 || n > 1000)
{
    Console.WriteLine("Invalid input. Please enter a number between 1 and 1000.");
    return;
}

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        p1++;
    }
    else if (number < 400)
    {
        p2++;
    }
    else if (number < 600)
    {
        p3++;
    }
    else if (number < 800)
    {
        p4++;
    }
    else
    {
        p5++;
    }
}

// Percentage calculation

double p1Percentage = (double)p1 / n * 100;
double p2Percentage = (double)p2 / n * 100;
double p3Percentage = (double)p3 / n * 100;
double p4Percentage = (double)p4 / n * 100;
double p5Percentage = (double)p5 / n * 100;

Console.WriteLine($"{p1Percentage:F2}%");
Console.WriteLine($"{p2Percentage:F2}%");
Console.WriteLine($"{p3Percentage:F2}%");
Console.WriteLine($"{p4Percentage:F2}%");
Console.WriteLine($"{p5Percentage:F2}%");