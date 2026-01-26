// Input

string number = "";
int sum = 0;
// Checks

while (number != "End")
{
    number = Console.ReadLine();
    if (number == "End")
    {
        Console.WriteLine("Goodbye");
        break;
    }
    int inputetNumber = int.Parse(number);

    while (inputetNumber != 0)
    {
        int num = inputetNumber % 10;
        sum += num;
        inputetNumber /= 10;
    }

    Console.WriteLine($"Sum of digits = {sum}");
    sum = 0;
}