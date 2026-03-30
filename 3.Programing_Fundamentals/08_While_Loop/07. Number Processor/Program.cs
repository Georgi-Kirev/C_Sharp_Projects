// Input

double num = double.Parse(Console.ReadLine());

// Checks

while (true)
{
    string word = Console.ReadLine();
    if (word == "Inc")
    {
        num++;
    }
    else if (word == "Dec")
    {
        num--;
    }
    else if (word == "End")
    {
        Console.WriteLine(num);
        break;
    }
    else
    {
        Console.WriteLine("Wrong command!");
    }
}