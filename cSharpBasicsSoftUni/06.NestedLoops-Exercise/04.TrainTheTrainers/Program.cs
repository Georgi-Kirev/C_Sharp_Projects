// Input

int numOfJury = int.Parse(Console.ReadLine());
if (numOfJury < 1 || numOfJury > 20)
{
    Console.WriteLine("Invalid number of Juries.");
    return;
}

double totalGradeSum = 0.0;
int totalGradeCount = 0;

while (true)
{
    string presentation = Console.ReadLine();
    if (presentation == "Finish")
    {
        break;
    }

    double gradesSum = 0.0;

    for (int i = 1; i <= numOfJury; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        gradesSum += grade;
        totalGradeSum += grade;
        totalGradeCount++;
    }
    double averageGrade = gradesSum / numOfJury;
    Console.WriteLine($"{presentation} - {averageGrade:F2}.");

}


Console.WriteLine($"Student's final assessment is {totalGradeSum / totalGradeCount:F2}.");