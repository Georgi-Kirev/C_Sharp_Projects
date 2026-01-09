// Input:

int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

// Calculation:

double volume = length * width * height;
double volumeLiters = volume * 0.001;
double occupiedSpace = percentage / 100;

double requiredLiters = volumeLiters * (1 - occupiedSpace);

// Output

Console.WriteLine($"{requiredLiters:F2}");