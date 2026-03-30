// Substitute

// Отпечатване на всички възможни футболни двойки за да се смени играчът

int K = int.Parse(Console.ReadLine()); // първа цифра първо число
int L = int.Parse(Console.ReadLine()); // втора цифра първо число
int M = int.Parse(Console.ReadLine()); // първа цифра второ число
int N = int.Parse(Console.ReadLine()); // втора цифра второ число


for (int i = K; i <= 8; i++)
{
    for (int j = 9; j >= L; j--)
    {
        for (int p = M; p <= 8; p++)
        {
            for (int q = 9; q >= N; q--)
            {
                int counter = 0;
                if (i % 2 == 0 && j % 2 != 0 && p % 2 == 0 && q % 2 != 0)
                {
                    if (i == p && j == q)
                    {
                        Console.WriteLine("Cannot change the same player.");
                        counter--;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"{i}{j} - {p}{q}");
                    }

                    counter++;

                    if (counter >= 6)
                    {
                        return;
                    }
                }
            }
        }
    }
}

