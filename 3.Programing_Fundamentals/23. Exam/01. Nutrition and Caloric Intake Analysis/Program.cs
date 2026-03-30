// Input

int countOfItems = int.Parse(Console.ReadLine());
int sumOfCalory = 0;

if (countOfItems <= 0)
{
    Console.WriteLine(sumOfCalory);
}
for (int i = 0; i < countOfItems; i++)
{
    int caloryAmmount = int.Parse((Console.ReadLine()));

    sumOfCalory += caloryAmmount;

    Console.WriteLine(sumOfCalory);
}