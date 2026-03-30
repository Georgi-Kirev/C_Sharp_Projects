// Input

string wordsFromConsole = Console.ReadLine();

while (wordsFromConsole != "end")
{
    string revercedWord = new string(wordsFromConsole.Reverse().ToArray());

    Console.WriteLine(wordsFromConsole + " = " + revercedWord);

    wordsFromConsole = Console.ReadLine();
}