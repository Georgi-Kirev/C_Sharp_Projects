// Input
int numLoads = int.Parse(Console.ReadLine());

// Integers
int totalLoads = 0;
int bussTons = 0;
int truckTons = 0;
int trainTons = 0;

//•	До 3 тона – микробус (200 лева на тон)
//•	От 4 до 11 тона – камион (175 лева на тон)
//•	12 и повече тона – влак (120 лева на тон)

for (int i = 0; i < numLoads; i++)
{
    int tons = int.Parse(Console.ReadLine());

    totalLoads += tons;

    if (tons <= 3)
    {
        bussTons += tons;
    }
    else if (tons >= 4 && tons <= 11)
    {
        truckTons += tons;
    }
    else if (tons >= 12)
    {
        trainTons += tons;
    }
}

double averagePerTons = (bussTons * 200 + truckTons * 175 + trainTons * 120) / (double)totalLoads;
double bussPercent = ((double)bussTons / totalLoads) * 100;
double truckPercent = ((double)truckTons / totalLoads) * 100;
double trainPercent = ((double)trainTons / totalLoads) * 100;

// Output
Console.WriteLine($"{averagePerTons:F2}");
Console.WriteLine($"{bussPercent:F2}%");
Console.WriteLine($"{truckPercent:F2}%");
Console.WriteLine($"{trainPercent:F2}%");