
int firstMax = int.Parse(Console.ReadLine());
int secondMax = int.Parse(Console.ReadLine());
int thirdMax = int.Parse(Console.ReadLine());

for (int first = 2; first <= firstMax; first += 2) // само четни
{
    for (int second = 2; second <= secondMax; second++)
    {
        // проверка за просто число между 2 и 7
        if (second != 2 && second != 3 && second != 5 && second != 7)
        {
            continue;
        }

        for (int third = 2; third <= thirdMax; third += 2) // само четни
        {
            Console.WriteLine($"{first} {second} {third}");
        }
    }
}
