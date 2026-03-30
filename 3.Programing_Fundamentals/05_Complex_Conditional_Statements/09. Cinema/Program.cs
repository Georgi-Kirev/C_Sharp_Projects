// Inputs

string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

// Constants

double premiere = 12.00;
double normal = 7.50;
double discount = 5.00;

// Checks and calculations

if (movieType == "Premiere")
{
    Console.WriteLine($"{((rows * seats) * premiere):F2}");
}
else if (movieType == "Normal")
{
    Console.WriteLine($"{((rows * seats) * normal):F2}");
}
else if (movieType == "Discount")
{
    Console.WriteLine($"{((rows * seats) * discount):F2}");
}