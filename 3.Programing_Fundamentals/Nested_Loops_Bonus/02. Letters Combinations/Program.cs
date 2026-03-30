// Input

char a = Console.ReadLine()[0];
char b = Console.ReadLine()[0];
char c = Console.ReadLine()[0];

char firstChar = ' ';
char secondChar = ' ';
char thirdChar = ' ';

int counter = 0;
// Checks

for (int i = a; i <= b; i++)
{
    firstChar = (char)i;

    for (int j = a; j <= b; j++)
    {
        secondChar = (char)j;
        for (int k = a; k <= b; k++)
        {
            thirdChar = (char)k;
            if (firstChar != c && secondChar != c && thirdChar != c)
            {
                Console.Write($"{firstChar}{secondChar}{thirdChar} ");
                counter++;
            }
        }
    }
}

Console.WriteLine(counter);