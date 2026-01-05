// Input
bool command = true;
int maxNum = int.MinValue;
while (command)
{
    string text = Console.ReadLine();
    if (text == "Stop")
    {
        Console.WriteLine($"{maxNum}");
        break;
    }

    int num = int.Parse(text);
    if (num > maxNum)
    {
        maxNum = num;
    }

}