// Input

List<int> passengersInWagons = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
int passengersMax = int.Parse(Console.ReadLine());
string action = Console.ReadLine();

while (action != "end")
{

    for (int i = 0; i < passengersInWagons.Count; i++)
    {
        if (action.StartsWith("Add"))
        {
            action = string.Concat(action.Where(char.IsDigit));
            passengersInWagons.Add(int.Parse(action));
            break;
        }
        if (passengersInWagons[i] < passengersMax && int.Parse(action) + passengersInWagons[i] <= passengersMax)
        {
            passengersInWagons[i] += int.Parse(action);
            break;
        }
    }

    action = Console.ReadLine();

}

Console.WriteLine(string.Join(" ", passengersInWagons));