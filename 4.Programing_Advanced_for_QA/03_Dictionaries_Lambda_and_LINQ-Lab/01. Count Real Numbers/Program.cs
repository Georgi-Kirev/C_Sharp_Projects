// Input

List<int> numbersFromConsole = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

SortedDictionary<int, int> howManyNum = new SortedDictionary<int, int>();


// Calculation 

foreach (var number in numbersFromConsole)
{
    if (howManyNum.ContainsKey(number))
    {
        howManyNum[number]++;
    }
    else
    {
        howManyNum.Add(number, 1);
    }
}

// Output

foreach (KeyValuePair<int, int> pairs in howManyNum)
{
    Console.WriteLine(pairs.Key + " -> " + pairs.Value);
}