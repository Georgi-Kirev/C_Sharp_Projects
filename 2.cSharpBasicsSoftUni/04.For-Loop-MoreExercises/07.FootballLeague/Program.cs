// Input
int stadionMax = int.Parse(Console.ReadLine());
int numFens = int.Parse(Console.ReadLine());
if (numFens < 1 || numFens > 10000 || stadionMax < 1 || stadionMax > 10000)
{ Console.WriteLine("Invalid Number"); return; }

double A = 0;
double B = 0;
double V = 0;
double G = 0;

for (int i = 0; i < numFens; i++)
{
    char fansSectors = char.Parse(Console.ReadLine());
    if (fansSectors != 'A' && fansSectors != 'B' && fansSectors != 'V' && fansSectors != 'G')
    { Console.WriteLine("Incorrect Fans Sector"); return; }

    if (fansSectors == 'A')
        A++;
    else if (fansSectors == 'B')
        B++;
    else if (fansSectors == 'V')
        V++;
    else if (fansSectors == 'G')
        G++;
}
// Percents of fans
double sectorA = (A / numFens) * 100;
double sectorB = (B / numFens) * 100;
double sectorV = (V / numFens) * 100;
double sectorG = (G / numFens) * 100;
double fansCapacity = ((double)numFens / stadionMax) * 100;

// Output

Console.WriteLine($"{sectorA:F2}%");
Console.WriteLine($"{sectorB:F2}%");
Console.WriteLine($"{sectorV:F2}%");
Console.WriteLine($"{sectorG:F2}%");
Console.WriteLine($"{fansCapacity:F2}%");