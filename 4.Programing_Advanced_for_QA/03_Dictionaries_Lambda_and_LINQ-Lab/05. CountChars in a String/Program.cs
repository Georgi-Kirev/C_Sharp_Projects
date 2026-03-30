// Input

string sentence = Console.ReadLine();
Dictionary<char, int> words = new Dictionary<char, int>();

// Action 

for (int i = 0; i < sentence.Length; i++)
{
    char c = sentence[i];

    if (c == ' ')
    {
        continue;
    }

    if (!words.ContainsKey(c))
    {
        words[c] = 1;
    }
    else
    {
        words[c]++;
    }
}

// Output

foreach (KeyValuePair<char, int> c in words)
{
    Console.WriteLine($"{c.Key} -> {c.Value}");
}