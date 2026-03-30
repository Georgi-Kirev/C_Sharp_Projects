// Input
double money = double.Parse(Console.ReadLine());
int year = int.Parse(Console.ReadLine());
int yearsOld = 18;
int startingYear = 1800;

// Output

for (int i = 1800; year >= i; i++)
{
    if (startingYear % 2 == 0)
    {
        money -= 12000;
        yearsOld++;
        startingYear++;
    }
    else
    {
        money = money - (12000 + (yearsOld * 50));
        yearsOld++;
        startingYear++;
    }

}


if (money >= 0)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {money:F2} dollars left.");
}
else
{
    Console.WriteLine($"He will need {Math.Abs(money):F2} dollars to survive.");
}