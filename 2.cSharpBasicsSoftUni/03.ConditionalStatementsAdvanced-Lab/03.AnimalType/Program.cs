// Input
string animal = Console.ReadLine();

// Calculations

if (animal == "dog")
{
    Console.WriteLine("mammal");
}
else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
{
    Console.WriteLine("reptile");
}
else
{
    Console.WriteLine("unknown");
}