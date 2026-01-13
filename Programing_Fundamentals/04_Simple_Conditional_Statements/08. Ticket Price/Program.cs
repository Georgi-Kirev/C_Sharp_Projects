// Input

string ticket = Console.ReadLine();

// Check

if (ticket == "student")
    Console.WriteLine("$1.00");
else if (ticket == "regular")
    Console.WriteLine("$1.60");
else
    Console.WriteLine("Invalid ticket type!");