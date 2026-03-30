// Input



int start = 1;
List<int> numbers = new List<int>(10);

while (numbers.Count < 10)
{
    try
    {
        int numFromConsole = ReadNumber(start, 100);
        numbers.Add(numFromConsole);
        start = numFromConsole;
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine($"Your number is not in range {start} - 100!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }



}

foreach (var item in numbers)
{
    if (numbers[9] == item)
    {
        Console.Write(item);
    }
    else
    {
        Console.Write(item + ", ");
    }
}



int ReadNumber(int start, int end)
{
    int number = int.Parse(Console.ReadLine());

    if (number <= start || number >= end)
    {
        throw new ArgumentOutOfRangeException();
    }
    return number;
}