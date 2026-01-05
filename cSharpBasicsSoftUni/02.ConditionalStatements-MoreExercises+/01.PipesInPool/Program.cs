// Input
int V = int.Parse(Console.ReadLine()); // Обем на басейна
int P1 = int.Parse(Console.ReadLine()); // Дебит на първата тръба за час
int P2 = int.Parse(Console.ReadLine()); // Дебит на втората тръба за час
double H = double.Parse(Console.ReadLine()); // Часовете в които работникът отсъства

// Calculation

double Volume = (P1 + P2) * H;
double percentFull = (Volume / V) * 100;
double percentP1Fill  = ((P1*H)/ Volume) * 100;
double percentP2Fill = ((P2*H) / Volume) * 100;
double ExesWater = Volume - V;
// Output

if  ( Volume <= V)
{
    Console.WriteLine($"The pool is {percentFull:F2}% full. Pipe 1: {percentP1Fill:F2}%. Pipe 2: {percentP2Fill:F2}%.");
}
else
{
    Console.WriteLine($"For {H:F2} hours the pool overflows with {ExesWater:F2} liters.");
}