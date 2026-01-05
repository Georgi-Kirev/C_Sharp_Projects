// Substitute
// Отпечатване на всички възможни футболни двойки за да се смени играчът

int K = int.Parse(Console.ReadLine()); // първа цифра първо число
int L = int.Parse(Console.ReadLine()); // втора цифра първо число
int M = int.Parse(Console.ReadLine()); // първа цифра второ число
int N = int.Parse(Console.ReadLine()); // втора цифра второ число

int counter = 0;

for (int i = K; i <= 8; i++) // първа цифра на първо число
{
    for (int j = 9; j >= L; j--) // втора цифра на първо число
    {
        for (int p = M; p <= 8; p++) // първа цифра на второ число
        {
            for (int q = 9; q >= N; q--) // втора цифра на второ число
            {
                // Проверка: i и p трябва да са четни, j и q - нечетни
                if (i % 2 == 0 && j % 2 != 0 && p % 2 == 0 && q % 2 != 0)
                {
                    if (i == p && j == q)
                    {
                        Console.WriteLine("Cannot change the same player.");
                        counter--;
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
