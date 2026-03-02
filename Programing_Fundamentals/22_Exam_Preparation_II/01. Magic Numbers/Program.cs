// Input

int numberN = int.Parse(Console.ReadLine());
bool foundMagic = false;

// Calculation and Output

for (int i = 1; i <= numberN; i++)
{
    int currentNum = i;
    int sumOfDigits = 0;
    bool isMagic = true;

    while (currentNum > 0)
    {
        int digit = currentNum % 10;

        if (digit != 2 && digit != 3 && digit != 5 && digit != 7)
        {
            isMagic = false;
            break;
        }

        sumOfDigits += digit;
        currentNum /= 10;
    }

    if (isMagic && sumOfDigits % 2 == 0)
    {
        Console.Write($"{i} ");
        foundMagic = true;
    }
}

if (!foundMagic)
{
    Console.WriteLine("no");
}