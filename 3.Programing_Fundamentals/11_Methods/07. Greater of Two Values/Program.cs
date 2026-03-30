// Input

string typeOfValues = Console.ReadLine();
string firstValue = Console.ReadLine();
string secondValue = Console.ReadLine();

// Output

Result(typeOfValues, firstValue, secondValue);

// Methods

static void Result(string typeOfValues, string firstValue, string secondValue)
{
    if (typeOfValues == "int")
    {
        int Value1 = int.Parse(firstValue);
        int Value2 = int.Parse(secondValue);
        if (Value1 > Value2)
        {
            Console.WriteLine(firstValue);
        }
        else
        {
            Console.WriteLine(secondValue);
        }
    }
    else
    {
        Console.WriteLine(secondValue);
    }
}