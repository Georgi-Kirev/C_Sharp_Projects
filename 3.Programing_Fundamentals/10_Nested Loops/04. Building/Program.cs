// Program that print a table, representing building:
// Input

int floorCount = int.Parse(Console.ReadLine()); // How many floors?
int estateCount = int.Parse(Console.ReadLine());// How many apartments?

// Calculation

for (int i = floorCount; 1 <= i; i--)
{
    int number = i * 10;
    if (i % 2 == 0 && i != floorCount)
    {
        for (int j = 0; j < estateCount; j++)
        {
            if (j + 1 != estateCount)
            {
                Console.Write($"{"O"}{number} ");
                number++;
            }
            else
            {
                Console.WriteLine($"{"O"}{number} ");
            }
        }
    }
    else if (i % 2 != 0 && i != floorCount)
    {
        for (int j = 0; j < estateCount; j++)
        {
            if (j + 1 != estateCount)
            {
                Console.Write($"{"A"}{number} ");
                number++;
            }
            else
            {
                Console.WriteLine($"{"A"}{number} ");
            }
        }
    }
    else
    {
        for (int j = 0; j < estateCount; j++)
        {
            if (j + 1 != estateCount)
            {
                Console.Write($"{"L"}{number} ");
                number++;
            }
            else
            {
                Console.WriteLine($"{"L"}{number} ");
            }
        }
    }
}