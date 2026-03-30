// Input
int age = int.Parse(Console.ReadLine());
double priceWasher = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

// Output
int toysCount = 0;
int moneySaved = 0;
for (int i = 1; i <= age; i++)
{
    if (i % 2 == 0)
    {
        moneySaved += (i / 2) * 10 - 1; // Every second birthday, save money and take out $1
    }
    else
    {
        toysCount++;
    }
}
moneySaved += toysCount * toyPrice; // Add money from toys
if (moneySaved >= priceWasher)
{
    Console.WriteLine($"Yes! {moneySaved - priceWasher:F2}");
}
else
{
    Console.WriteLine($"No! {priceWasher - moneySaved:F2}");
}

