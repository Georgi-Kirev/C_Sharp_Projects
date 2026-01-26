// Input

int startNumber = int.Parse(Console.ReadLine());
int endNumber = int.Parse(Console.ReadLine());

for (int i = startNumber; i <= endNumber; i++)
{
    if (i < 2) // 0 и 1 не са прости числа
        continue;

    bool isPrime = true;

    for (int j = 2; j < i; j++) // проверяваме делителите от 2 до i-1
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.Write($"{i} ");
    }
}
