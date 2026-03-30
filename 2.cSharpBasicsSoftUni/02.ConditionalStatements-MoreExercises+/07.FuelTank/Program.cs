// Input
string fuel = Console.ReadLine();
int ammount = int.Parse(Console.ReadLine());

// Output
if (fuel != "diesel" && fuel != "gasoline" && fuel != "gas" && fuel != "Diesel" && fuel != "Gasoline" && fuel != "Gas")
{ 
    Console.WriteLine("Invalid fuel!");
    return;
}
    

if (ammount >= 25)
{
    Console.WriteLine($"You have enough {fuel.ToLower()}.");
}
else if (ammount < 25)
{
    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
}