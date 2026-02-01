// Input

string inputText = Console.ReadLine();

// Output

Console.WriteLine(VowelCounter(inputText));

// Methods

static string VowelCounter(string text)
{
    int vowelCount = 0;
    for (int i = 0; i < text.Length; i++)
    {
        char c = text[i];
        switch (c)
        {
            case 'a' or 'A' or 'e' or 'E' or 'i' or 'I' or 'o' or 'O' or 'u' or 'U':
                vowelCount++;
                break;
        }
    }
    return vowelCount.ToString();
}
