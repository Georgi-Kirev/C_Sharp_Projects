// Lucky number
// Take 1 number and print all lucky numbers. Lucky number is 4 numbered first sum of first 2
// and sum of second 2 are equals and hole number has to be divisible by the sum of the first 2
// digits without a remainder.


// Input

int n = int.Parse(Console.ReadLine());

// Calculation

for (int firstNum = 1; firstNum <= 9; firstNum++)
{
    for (int secondNum = 1; secondNum <= 9; secondNum++)
    {
        for (int thirdNum = 1; thirdNum <= 9; thirdNum++)
        {
            for (int fourthNum = 1; fourthNum <= 9; fourthNum++)
            {
                if (firstNum + secondNum == thirdNum + fourthNum)
                {
                    int sum = firstNum + secondNum;

                    int number = firstNum * 1000 + secondNum * 100 + thirdNum * 10 + fourthNum;

                    if (n % sum == 0)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
        }
    }
}
