// Input
int simple = 0;
int notSimple = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "stop") break;

    int number = int.Parse(input);
    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    bool isPrime = number == 2;

    if (number > 2)
    {
        if (number % 2 != 0)
        {
            isPrime = true;
            int divisor = 3;
            while (divisor * divisor <= number)
            {
                if (number % divisor == 0)
                {
                    isPrime = false;
                    break;
                }

                divisor += 2;
            }
        }
    }

    if (isPrime)
    {
        simple += number;
    }
    else
    {
        notSimple += number;
    }

}

Console.WriteLine($"Sum of all prime numbers is: {simple}");
Console.WriteLine($"Sum of all non prime numbers is: {notSimple}");