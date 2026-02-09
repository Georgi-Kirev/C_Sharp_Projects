// Input

List<int> theList = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string input;

while ((input = Console.ReadLine()) != "end")
{
    string[] parts = input.Split(" ");
    string name = parts[0];
    int value = int.Parse(parts[1]);


    if (name == "Add")
    {
        theList.Add(value);
    }
    else if (name == "Remove")
    {
        theList.Remove(value);
    }
    else if (name == "RemoveAt")
    {
        theList.RemoveAt(value);
    }
    else if (name == "Insert")
    {
        theList.Insert(int.Parse(parts[2]), value);
    }

}

Console.WriteLine(string.Join(" ", theList));