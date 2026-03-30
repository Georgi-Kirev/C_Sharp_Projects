// Input
int numberOfClimbers = int.Parse(Console.ReadLine());

// Output
int totalClimbers = 0;
int totalTrekkingGroups = 0;
int totalPeople = 0;
int[] climbersPerGroup = new int[5]; // Array to hold the number of climbers in each group
for (int i = 0; i < numberOfClimbers; i++)
{
    int climbersInGroup = int.Parse(Console.ReadLine());
    totalPeople += climbersInGroup;
    totalClimbers++;

    // Determine the group size and increment the corresponding index in the array
    if (climbersInGroup <= 5)
    {
        climbersPerGroup[0] += climbersInGroup;
    }
    else if (climbersInGroup <= 12)
    {
        climbersPerGroup[1] += climbersInGroup;
    }
    else if (climbersInGroup <= 25)
    {
        climbersPerGroup[2] += climbersInGroup;
    }
    else if (climbersInGroup <= 40)
    {
        climbersPerGroup[3] += climbersInGroup;
    }
    else
    {
        climbersPerGroup[4] += climbersInGroup;
    }
}
// Calculate the percentage of climbers in each group
double[] percentages = new double[5];
for (int i = 0; i < climbersPerGroup.Length; i++)
{
    percentages[i] = (double)climbersPerGroup[i] / totalPeople * 100;
}
// Output the results
Console.WriteLine($"{percentages[0]:F2}%");
Console.WriteLine($"{percentages[1]:F2}%");
Console.WriteLine($"{percentages[2]:F2}%");
Console.WriteLine($"{percentages[3]:F2}%");
Console.WriteLine($"{percentages[4]:F2}%");
// Console.WriteLine($"{totalPeople} total climbers in {totalClimbers} trekking groups.");
// End of the program