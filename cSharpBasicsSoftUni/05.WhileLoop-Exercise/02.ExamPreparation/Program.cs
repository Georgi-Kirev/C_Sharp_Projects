// Input
int maxBadGrades = int.Parse(Console.ReadLine());
int badGrades = 0;
double totalGradesScore = 0;
int problems = 0;
string lastProblem = "";
bool input = true;
while (input == true)
{
    string taskName = Console.ReadLine();
    if (taskName == "Enough")
    {
        input = false;
        break;
    }
    int grade = int.Parse(Console.ReadLine());
    if (grade < 2 || grade > 6)
        Console.WriteLine("Incorrect grade!");
    totalGradesScore += grade;
    problems++;
    lastProblem = taskName;
    if (grade <= 4)
    {
        badGrades++;
        if (badGrades == maxBadGrades)
        {
            Console.WriteLine($"You need a break, {badGrades} poor grades.");
            return;
        }
    }


}

double averageScore = totalGradesScore / problems;

Console.WriteLine($"Average score: {averageScore:F2}");
Console.WriteLine($"Number of problems: {problems}");
Console.WriteLine($"Last problem: {lastProblem}");