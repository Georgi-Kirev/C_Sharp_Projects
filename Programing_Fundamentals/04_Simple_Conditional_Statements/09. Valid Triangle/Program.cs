// Input

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

// Check
if (x + y > z && y + z > x && x + z > y)
    Console.WriteLine("Valid Triangle");
else
    Console.WriteLine("Invalid Triangle");