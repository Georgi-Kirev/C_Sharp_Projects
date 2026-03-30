// Input

string consoleString = Console.ReadLine();

// Variables

string numbers = "";
string letters = "";
string specialChars = "";

// Actions

for (int i = 0; i < consoleString.Length; i++)
{
    if (char.IsDigit(consoleString[i]))
    {
        numbers += consoleString[i];
    }
    else if (char.IsLetter(consoleString[i]))
    {
        letters += consoleString[i];
    }
    else
    {
        specialChars += consoleString[i];
    }
}

// Output

Console.WriteLine(numbers);
Console.WriteLine(letters);
Console.WriteLine(specialChars);
