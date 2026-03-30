// Input
string name = Console.ReadLine();
double totalGrade = 0;
double yearGrade = 0;
int yearsInSchool = 0;
double fail = 0;
while (yearsInSchool != 12)
{
    double grade = double.Parse(Console.ReadLine());

    if (grade < 2 || grade > 6)
    {
        Console.WriteLine("Invalid grade!");
    }
    totalGrade += grade;
    yearGrade = grade;
    if (fail > 0)
    {
        break;
    }

    yearsInSchool++;

    if (grade < 3 || yearGrade < 4.00)
    {
        fail++;
    }
}

double averageGrade = 0;
if (yearsInSchool > 0)
{
    averageGrade = totalGrade / yearsInSchool;
}

double fail2 = fail;
if (fail2 == 0)
{
    Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
}
else if (fail2 >= 1)
{
    Console.WriteLine($"{name} has been excluded at {yearsInSchool} grade");
}