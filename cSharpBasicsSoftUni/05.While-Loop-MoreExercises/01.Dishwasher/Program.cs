// Input
int numBottles = int.Parse(Console.ReadLine());
if (numBottles < 1 || numBottles > 10)
{
    Console.WriteLine("Too much or too little bottles!");
    return;
}

int totalDetergent = numBottles * 750; // total number of detergent in ml
int dish = 5; // 5ml needed for washing 1 dish
int pot = 15; // 15ml needed for washing 1 pot
int dishesWashed = 0;
int potsWashed = 0;
int numdays = 0;

while (true)
{
    string input = Console.ReadLine();
    if (input == "End")
    {
        Console.WriteLine("Detergent was enough!");
        Console.WriteLine($"{dishesWashed} dishes and {potsWashed} pots were washed.");
        Console.WriteLine($"Leftover detergent {totalDetergent} ml.");
        break;
    }
    int numberTableWare = int.Parse(input);
    if (numberTableWare < 1 || numberTableWare > 100)
    {
        Console.WriteLine("Too much or too little number of Tableware!");
        break;
    }

    numdays++;

    if (numdays % 3 == 0)
    {
        totalDetergent -= numberTableWare * pot;
        potsWashed += numberTableWare;
        numdays = 0;
    }
    else
    {
        totalDetergent -= numberTableWare * dish;
        dishesWashed += numberTableWare;
    }

    if (totalDetergent < 0)
    {
        Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergent)} ml. more necessary!");
        break;
    }


}