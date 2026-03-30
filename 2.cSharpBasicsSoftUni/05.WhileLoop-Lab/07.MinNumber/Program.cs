// Input
bool command = true;
int minNum = int.MaxValue;
while (command)
{
    string text = Console.ReadLine();
    if (text == "Stop")
    {
        Console.WriteLine($"{minNum}");
        break;
    }

    int num = int.Parse(text);
    if (num < minNum)
    {
        minNum = num;
    }

}