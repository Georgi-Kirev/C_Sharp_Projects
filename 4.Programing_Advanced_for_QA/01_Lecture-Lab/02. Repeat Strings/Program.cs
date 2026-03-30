// Input

using System.Linq;

string[] stringsFromConsole = Console.ReadLine().Split(" ").ToArray();

int cycles = stringsFromConsole.Length;

for (int i = 0; i < cycles; i++)
{
    string word = stringsFromConsole[i];

    for (int j = 0; j < word.Length; j++)
    {
        Console.Write(word.Trim());
    }

}