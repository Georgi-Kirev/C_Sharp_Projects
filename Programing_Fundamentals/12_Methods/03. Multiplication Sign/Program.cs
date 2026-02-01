// Input

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

// Output

Console.WriteLine(CheckNumbersProduct(num1, num2, num3));

// Methods

static string CheckNumbersProduct(int num1, int num2, int num3)
{
    string result = "";
    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        result = "zero";
        return result;
    }
    int negativeNumbers = 0;

    if (num1 < 0) negativeNumbers++;
    if (num2 < 0) negativeNumbers++;
    if (num3 < 0) negativeNumbers++;

    if (negativeNumbers % 2 != 0)
    {
        result = "negative";
    }
    else
    {
        result = "positive";
    }
    return result;
}