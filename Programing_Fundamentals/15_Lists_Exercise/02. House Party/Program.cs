// Input

int numbersOfInteractions = int.Parse(Console.ReadLine());
List<string> names = new List<string>();


for (int i = 1; i <= numbersOfInteractions; i++)
{
    string input = Console.ReadLine();
    string[] parts = input.Split(" ");
    string name = parts[0];
    if (input.Contains("is going!"))
    {
        if (!names.Contains(name))
        {
            names.Add(name);
        }
        else if (names.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");

        }
    }
    else if (input.Contains("not going!"))
    {
        if (!names.Contains(name))
        {
            Console.WriteLine($"{name} is not in the list!");

        }
        else if (names.Contains(name))
        {
            names.Remove(name);
        }
    }


}

foreach (string j in names)
{
    Console.WriteLine(j);
}