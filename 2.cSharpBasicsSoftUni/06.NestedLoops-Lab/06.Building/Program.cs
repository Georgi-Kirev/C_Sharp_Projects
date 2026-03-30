// Input
int numberFlores = int.Parse(Console.ReadLine());
int numbersOfRooms = int.Parse(Console.ReadLine());

for (int i = numberFlores; i >= 1; i--)
{

    for (int room = 0; room < numbersOfRooms; room++)
    {
        if (i == numberFlores)
        {
            Console.Write($"L{i}{room} "); // Последен етаж
        }
        else if (i % 2 == 0)
        {
            Console.Write($"O{i}{room} "); // Апартаменти
        }
        else if (i % 2 != 0)
        {
            Console.Write($"A{i}{room} "); // офиси
        }
    }

    Console.WriteLine();
}
