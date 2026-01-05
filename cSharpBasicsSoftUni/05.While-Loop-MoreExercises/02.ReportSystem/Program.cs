// Input
int moneyExpected = int.Parse(Console.ReadLine());

if (moneyExpected < 1 || moneyExpected > 10000)
{
    Console.WriteLine("Incorrect money amount!");
    return;
}

int paymentStep = 0;  // Counter for payment if is odd is with cash if it even it is with card
int paymentsCash = 0;
double moneyCollectedCash = 0;
int paymentsCard = 0;
double moneyCollectedCard = 0;
int moneyCollected = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "End")
    {
        Console.WriteLine("Failed to collect required money for charity.");
        break;
    }
    int money = int.Parse(input);
    paymentStep++;

    if (paymentStep % 2 != 0 && money > 100) // cash payment
    {
        Console.WriteLine("Error in transaction!");
        continue;
    }
    else if (paymentStep % 2 != 0)
    {
        Console.WriteLine("Product sold!");
        moneyCollected += money;
        paymentsCash++;
        moneyCollectedCash += money;

    }
    else if (paymentStep % 2 == 0 && money < 10) // card payment
    {
        Console.WriteLine("Error in transaction!");
        continue;
    }
    else if (paymentStep % 2 == 0)
    {
        Console.WriteLine("Product sold!");
        moneyCollected += money;
        paymentsCard++;
        moneyCollectedCard += money;
    }

    if (moneyCollected >= moneyExpected)
    {
        Console.WriteLine($"Average CS: {moneyCollectedCash / paymentsCash:F2}");
        Console.WriteLine($"Average CC: {moneyCollectedCard / paymentsCard:F2}");
        break;
    }

}