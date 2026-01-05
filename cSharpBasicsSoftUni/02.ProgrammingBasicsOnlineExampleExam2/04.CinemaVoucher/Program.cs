int voucher = int.Parse(Console.ReadLine());

int ticketsCount = 0;
int purchasesCount = 0;

string input;

while ((input = Console.ReadLine()) != "End")
{
    int price = 0;

    if (input.Length > 8)
    {
        // Филм → сума от ASCII на първите два символа
        price = input[0] + input[1];
        if (voucher >= price)
        {
            ticketsCount++;
            voucher -= price;
        }
        else
        {
            break;
        }
    }
    else
    {
        // Покупка → ASCII на първия символ
        price = input[0];
        if (voucher >= price)
        {
            purchasesCount++;
            voucher -= price;
        }
        else
        {
            break;
        }
    }
}

Console.WriteLine(ticketsCount);
Console.WriteLine(purchasesCount);
