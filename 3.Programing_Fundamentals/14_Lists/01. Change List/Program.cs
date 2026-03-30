// Input

List<int> inputString = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string action = Console.ReadLine();

// Calculation and Output

while (action != "end")
{


    if (action.StartsWith("Delete"))
    {
        int num = int.Parse(action.Split(" ")[1]);
        inputString.RemoveAll(element => element == num);
    }
    else if (action.StartsWith("Insert"))
    {
        int numToInsert = int.Parse(action.Split(" ")[1]);
        int positionToInsert = int.Parse(action.Split(" ")[2]);
        inputString.Insert(positionToInsert, numToInsert);
    }

    action = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", inputString));