// Input

string firstString = Console.ReadLine();
string secondString = Console.ReadLine();

// Calculation Actions

while (secondString.Contains(firstString))
{
    secondString = secondString.Replace(firstString, "");
}

// Output Print

Console.WriteLine(secondString);