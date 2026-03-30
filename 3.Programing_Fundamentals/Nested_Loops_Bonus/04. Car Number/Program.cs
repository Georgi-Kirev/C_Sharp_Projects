// Special Car Number Generator

// Input

int firstN = int.Parse(Console.ReadLine());
int secondN = int.Parse(Console.ReadLine());


// Calculation

for (int firstNum = 1; firstNum <= 9; firstNum++)
{
    for (int secondNum = 1; secondNum <= 9; secondNum++)
    {
        for (int thirdNum = 1; thirdNum <= 9; thirdNum++)
        {
            for (int fourthNum = 1; fourthNum <= 9; fourthNum++)
            {
                if (firstNum >= firstN && secondNum >= firstN && thirdNum >= firstN && fourthNum >= firstN && firstNum <= secondN && secondNum <= secondN && thirdNum <= secondN && fourthNum <= secondN && firstNum > fourthNum)
                {
                    if (firstNum % 2 == 0 && fourthNum % 2 != 0 || firstNum % 2 != 0 && fourthNum % 2 == 0)
                    {
                        if ((secondNum + thirdNum) % 2 == 0)
                        {
                            int number = firstNum * 1000 + secondNum * 100 + thirdNum * 10 + fourthNum;
                            Console.Write(number + " ");
                        }
                    }
                }
            }
        }
    }
}