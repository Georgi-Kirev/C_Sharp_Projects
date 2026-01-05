// Input
string actorName = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int numJuryMembers = int.Parse(Console.ReadLine());
double totalPoints = academyPoints;
// Output
// Loop through each jury member to calculate the total points

for (int i = 0; i < numJuryMembers; i++)
{
    string juryMemberName = Console.ReadLine();
    double pointsGiven = double.Parse(Console.ReadLine());

    // Calculate the points given by the jury member
    totalPoints += (juryMemberName.Length * pointsGiven) / 2.0;

    if (totalPoints >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
        break;
    }

}

// Check if the actor has enough points to win

if (totalPoints <= 1250.5)
{
    double pointsNeeded = 1250.5 - totalPoints;
    Console.WriteLine($"Sorry, {actorName} you need {pointsNeeded:F1} more!");
}
// End of the program