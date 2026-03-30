// Input

int numerOne = int.Parse(Console.ReadLine());
int numberTwo = int.Parse(Console.ReadLine());

// Output

Console.WriteLine(FactorialCalculation(numerOne) / FactorialCalculation(numberTwo));

// Methods

static int FactorialCalculation(int numbers)
{
    int result = 1;
    for (int i = 1; i < numbers; i++)
    {
        result = result * (i + 1);
    }
    return result;
}