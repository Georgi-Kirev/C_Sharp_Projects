// Challenge the Wedding

// Input

int numbersMan = int.Parse(Console.ReadLine());
int numbersWoman = int.Parse(Console.ReadLine());
int maxNumOfTables = int.Parse(Console.ReadLine());
int counter = 0;

// Calculation and Actions

for (int j = 1; j <= numbersMan; j++)
{
    for (int k = 1; k <= numbersWoman; k++)
    {
        if (maxNumOfTables >= j && maxNumOfTables >= k && counter != maxNumOfTables)
        {
            Console.Write($"({j} <-> {k}) ");
            counter++;
        }
        if (k == numbersWoman)
        {
            k = 1;
            break;
        }

    }
}
