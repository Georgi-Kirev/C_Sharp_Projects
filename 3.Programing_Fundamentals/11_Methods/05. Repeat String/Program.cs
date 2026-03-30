// Input

string test = Console.ReadLine();
int count = int.Parse(Console.ReadLine());


Console.WriteLine(Counter(test, count));


// Methods

static string Counter(string test, int count)
{
    string result = "";
    for (int i = 0; i < count; i++)
    {
        result += test;
    }
    return result;
}