// Inputs
int numOfStudents = int.Parse(Console.ReadLine());

if (numOfStudents <= 0 || numOfStudents > 1000)
{
    Console.WriteLine("Incorrect Number");
    return;
}

// numbers of any type and total grades number
double totalGrade = 0;
double dvoikadjii = 0;
double troikadjii = 0;
double chetvorkadjii = 0;
double otlichnici = 0;

for (int i = 0; i < numOfStudents; i++)
{
    double grade = double.Parse(Console.ReadLine());

    if (grade < 2.00 || grade > 6.00)
    {
        Console.WriteLine("Incorrect Number");
        return;
    }

    totalGrade += grade;

    if (grade >= 2.00 && grade <= 2.99)
    {
        dvoikadjii++;
    }
    else if (grade >= 3.00 && grade <= 3.99)
    {
        troikadjii++;
    }
    else if (grade >= 4.00 && grade <= 4.99)
    {
        chetvorkadjii++;
    }
    else if (grade >= 5.00)
    {
        otlichnici++;
    }
}

// Percentage calculations

double dvoikadjiiPercent = dvoikadjii / numOfStudents * 100;
double troikadjiiPercent = troikadjii / numOfStudents * 100;
double chetvorkadjiiPercent = chetvorkadjii / numOfStudents * 100;
double otlichniciPercent = otlichnici / numOfStudents * 100;

// Average calculations

double average = totalGrade / numOfStudents;

// Output

Console.WriteLine($"Top students: {otlichniciPercent:F2}%");
Console.WriteLine($"Between 4.00 and 4.99: {chetvorkadjiiPercent:F2}%");
Console.WriteLine($"Between 3.00 and 3.99: {troikadjiiPercent:F2}%");
Console.WriteLine($"Fail: {dvoikadjiiPercent:F2}%");
Console.WriteLine($"Average: {average:F2}");