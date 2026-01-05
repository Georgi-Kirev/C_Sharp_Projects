// Input
int numOfPlayers = int.Parse(Console.ReadLine());

if (numOfPlayers < 0 && numOfPlayers > 100)
{
    Console.WriteLine("Invalid Number");
    return;
}
//•	От 0 до 9  20 % от числото
//•	От 10 до 19  30 % от числото
//•	От 20 до 29  40 % от числото
//•	От 30 до 39  50 точки
//•	От 40 до 50  100 точки
//•	Невалидно число  резултата се дели на 2
//Освен резултата програмата трябва да изкарва статистика за проценти числа в дадените интервали.

// Checking numbers

double points = 0;
double zeroTo9 = 0;
double TenTo19 = 0;
double TwentyTo29 = 0;
double ThirtyTo39 = 0;
double FortyTo50 = 0;
double invalidNumbers = 0;

for (int i = 0; i < numOfPlayers; i++)
{
    int numberOfATurn = int.Parse(Console.ReadLine());

    if (numberOfATurn < -100 && numberOfATurn > 100)
    {
        Console.WriteLine("Invalid number");
        return;
    }

    if (numberOfATurn >= 0 && numberOfATurn <= 9)
    {
        points = points + (numberOfATurn * 0.2);
        zeroTo9++;
    }
    else if (numberOfATurn >= 10 && numberOfATurn <= 19)
    {
        points = points + (numberOfATurn * 0.3);
        TenTo19++;
    }
    else if (numberOfATurn >= 20 && numberOfATurn <= 29)
    {
        points = points + (numberOfATurn * 0.4);
        TwentyTo29++;
    }
    else if (numberOfATurn >= 30 && numberOfATurn <= 39)
    {
        points += 50;
        ThirtyTo39++;
    }
    else if (numberOfATurn >= 40 && numberOfATurn <= 50)
    {
        points += 100;
        FortyTo50++;
    }
    else if (numberOfATurn < 0 || numberOfATurn > 50)
    {
        points -= points / 2;
        invalidNumbers++;
    }
}

// Calculations
double zeroTo9Percent = (zeroTo9 / numOfPlayers) * 100;
double tenTo19Percent = (TenTo19 / numOfPlayers) * 100;
double twentyTo29Percent = (TwentyTo29 / numOfPlayers) * 100;
double thirtyTo39Percent = (ThirtyTo39 / numOfPlayers) * 100;
double fortyTo50Percent = (FortyTo50 / numOfPlayers) * 100;
double invalidNumbersPercent = (invalidNumbers / numOfPlayers) * 100;

// Output

Console.WriteLine($"{points:F2}");
Console.WriteLine($"From 0 to 9: {zeroTo9Percent:F2}%");
Console.WriteLine($"From 10 to 19: {tenTo19Percent:F2}%");
Console.WriteLine($"From 20 to 29: {twentyTo29Percent:F2}%");
Console.WriteLine($"From 30 to 39: {thirtyTo39Percent:F2}%");
Console.WriteLine($"From 40 to 50: {fortyTo50Percent:F2}%");
Console.WriteLine($"Invalid numbers: {invalidNumbersPercent:F2}%");