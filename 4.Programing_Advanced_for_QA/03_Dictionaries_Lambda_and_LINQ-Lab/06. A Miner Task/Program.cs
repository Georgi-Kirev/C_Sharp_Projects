// Input

using System.Diagnostics.Tracing;

string word = Console.ReadLine();
Dictionary<string, int> table = new Dictionary<string, int>();

// Calculation and Actions

while (word != "stop")
{
    int num = int.Parse(Console.ReadLine());

    if (!table.ContainsKey(word))
    {
        table[word] = num;
    }
    else
    {
        table[word] += num;
    }

    word = Console.ReadLine();
}

// Output

foreach (KeyValuePair<string, int> pair in table)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
