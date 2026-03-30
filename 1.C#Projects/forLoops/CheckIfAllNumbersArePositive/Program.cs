// провери дали всички числа са положителни!!

// Input
Console.WriteLine("Enter haw many numbers you want to check.");
if (!int.TryParse(Console.ReadLine(), out int N))
{
    Console.WriteLine("Invalid number!Please enter valid hole number.");
    return;
}

bool allPositive = true;
for (int i = 1; i <= N; i++)
{
    if (int.TryParse(Console.ReadLine(), out int allNum))
    { Console.WriteLine("Invalid number!Please enter valid hole number."); return; }

    if (allNum < 0) { allPositive = false; }

    if (allPositive == true)
    {
        Console.WriteLine("All numbers are positive.");
    }
    else
    {

        Console.WriteLine("Not all numbers are positive.");
    }
}/////// NEPRAVILNO ISKA REMONT