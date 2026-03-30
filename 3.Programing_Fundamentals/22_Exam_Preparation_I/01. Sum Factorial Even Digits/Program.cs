// Input

int inputNumber = int.Parse(Console.ReadLine());
int sum = 0;

// Calculation

while (inputNumber > 0)
{
    int workerNumber = inputNumber % 10;

    if (workerNumber % 2 == 0)
    {
        int isFactorial = 1;
        for (int i = 1; i <= workerNumber; i++)
        {

            isFactorial = isFactorial * i;

        }
        sum += isFactorial;
    }

    inputNumber = inputNumber / 10;
}

// Output
Console.WriteLine(sum);