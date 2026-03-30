// Input
int rent = int.Parse(Console.ReadLine()!);

// Calculation
double statuettes = rent * 0.70;
double catering = statuettes * 0.85;
double sound = catering / 2;
double totalExpenses = rent + statuettes + catering + sound;
// Output
Console.WriteLine($"{totalExpenses:F2}");