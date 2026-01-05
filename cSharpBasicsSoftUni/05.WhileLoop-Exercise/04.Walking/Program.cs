// Input
int goal = 10000;
int stepsDay = 0;

while (true)
{
    string goHome = Console.ReadLine();
    if (goHome == "Going home")
    {
        int stepsToHome = int.Parse(Console.ReadLine());
        stepsDay += stepsToHome;
        break;
    }
    int stepsThatDay = int.Parse(goHome);

    stepsDay += stepsThatDay;
    if (stepsDay >= goal)
    {
        break;
    }

}

if (goal >= stepsDay)
{
    Console.WriteLine($"{goal - stepsDay} more steps to reach goal.");
}
else
{
    Console.WriteLine($"Goal reached! Good job!");
    Console.WriteLine($"{stepsDay - goal} steps over the goal!");
}