// Input

int theNumber = Math.Abs(int.Parse(Console.ReadLine()));

// Output

Console.WriteLine(GetMultipleOfEvenAndOdds(theNumber));

// Methods

static int GetMultipleOfEvenAndOdds(int num)
{
    int result = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
    return result;
}

static int GetSumOfEvenDigits(int num)
{
    int Even = 0;
    while (num > 0)
    {
        int digit = num % 10;
        if (digit % 2 == 0)
        {
            Even += digit;
        }
        num /= 10;
    }
    return Even;
}

static int GetSumOfOddDigits(int num)
{
    int Odd = 0;
    while (num > 0)
    {
        int digit = num % 10;
        if (digit % 2 != 0)
        {
            Odd += digit;
        }
        num /= 10;
    }
    return Odd;
}