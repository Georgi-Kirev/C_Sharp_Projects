// Input

List<string> stringFromConsol = Console.ReadLine().Split(" ").ToList();
Dictionary<string, int> occurrences = new Dictionary<string, int>();

foreach (string line in stringFromConsol)
{
    string lineWithLowerLetters = line.ToLower();

    if (!occurrences.ContainsKey(lineWithLowerLetters))
    {
        occurrences.Add(lineWithLowerLetters, 1);
    }
    else
    {
        occurrences[lineWithLowerLetters]++;
    }
}

foreach (KeyValuePair<string, int> pairs in occurrences)
{
    if (pairs.Value % 2 != 0)
    {
        Console.Write(pairs.Key + " ");
    }
}

