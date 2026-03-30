// Input
int n = int.Parse(Console.ReadLine());
if (n < 1 || n > 600000)
{
    Console.WriteLine("Invalid number.");
    return;
}


for (int i = 1111; i < 9999; i++)
{
    int numberCopy = i;
    bool isSpecial = true;

    while (numberCopy > 0)
    {
        int digit = numberCopy % 10;
        if (digit == 0 || n % digit != 0)
        {
            isSpecial = false;
            break;
        }
        numberCopy /= 10;
    }

    if (isSpecial)
    {
        Console.Write(i + " ");
    }

}