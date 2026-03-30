// Сумиране на четни и нечетни числа
// Input

Console.WriteLine("How many numbers you will add?"); // Numbers that you want to add
int N = int.Parse(Console.ReadLine()); // Actual numbers that you want to sum

// Calculations
int evenCount = 0;
int oddCount = 0;

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());

    if (number % 2 == 0) evenCount++;
    else oddCount++;
}

Console.WriteLine("Even numbers:" + evenCount);
Console.WriteLine("Odd numbers:" + oddCount);
