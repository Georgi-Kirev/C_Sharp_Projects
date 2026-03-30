// Input

string[] wordsFromConsole = Console.ReadLine().Split(" ").ToArray();

for (int i = 0; i < wordsFromConsole.Length; i++)
{
    string word = wordsFromConsole[i];

    if (word.Length % 2 == 0)
    {
        Console.WriteLine(wordsFromConsole[i]);
    }
}