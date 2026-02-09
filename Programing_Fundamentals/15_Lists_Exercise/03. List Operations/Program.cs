// Input

List<int> listOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string commands;

while ((commands = Console.ReadLine()) != "End")
{
    string[] parts = commands.Split(" ");
    string actions = parts[0];
    int number;
    bool indexPosition = int.TryParse(parts[1], out number);

    if (indexPosition)
    {
        number = int.Parse(parts[1]);
    }
    else
    {
        number = int.Parse(parts[2]);
    }


    if (actions == "Add")
    {
        listOfInts.Add(number);
    }
    else if (actions == "Insert")
    {
        if (int.Parse(parts[2]) < 0 || int.Parse(parts[2]) >= listOfInts.Count)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        listOfInts.Insert(int.Parse(parts[2]), number);
    }
    else if (actions == "Remove")
    {
        if (number < 0 || number >= listOfInts.Count)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        listOfInts.RemoveAt(number);
    }
    else if (parts[0] == "Shift" && parts[1] == "left")
    {
        for (int i = 0; i < int.Parse(parts[2]); i++)
        {
            int num = (listOfInts[0]);
            listOfInts.Remove(listOfInts[0]);
            listOfInts.Add(num);
        }


    }
    else if (parts[0] == "Shift" && parts[1] == "right")
    {
        for (int i = 0; i < int.Parse(parts[2]); i++)
        {
            int num = (listOfInts.Last());
            listOfInts.Remove(listOfInts.Last());
            listOfInts.Insert(0, num);
        }
    }
}

Console.WriteLine(string.Join(" ", listOfInts));