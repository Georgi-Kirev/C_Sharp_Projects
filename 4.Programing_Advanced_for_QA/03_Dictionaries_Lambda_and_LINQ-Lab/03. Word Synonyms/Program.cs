// Input and Action

using System.Collections.Generic;
Dictionary<string, List<string>> wordsAndSynonyms = new Dictionary<string, List<string>>();
int countOfTheWord = int.Parse(Console.ReadLine());

for (int i = 0; i < countOfTheWord; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!wordsAndSynonyms.ContainsKey(word))
    {

        wordsAndSynonyms.Add(word, new List<string>() { synonym });
    }
    else
    {
        wordsAndSynonyms[word].Add(synonym);

    }


}
// Output

foreach (KeyValuePair<string, List<string>> keyValuePair in wordsAndSynonyms)
{
    Console.WriteLine(keyValuePair.Key + " - " + string.Join(", ", keyValuePair.Value));
}