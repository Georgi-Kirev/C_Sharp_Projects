// Input
int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());

for (int currentNumber = first; currentNumber <= second; currentNumber++)
{
    int oddSum = 0;
    int evenSum = 0;
    int extractedNumber = currentNumber;

    for (int position = 0; position < 6; position++)
    {
        int digit = extractedNumber % 10;

        if (position % 2 == 0)
        {
            evenSum += digit;
        }
        else if (position % 2 != 0)
        {
            oddSum += digit;
        }

        extractedNumber /= 10;
    }

    if (evenSum == oddSum)
    {
        Console.Write($"{currentNumber} ");
    }
}