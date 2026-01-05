// Input
int timeOfCalculations = int.Parse(Console.ReadLine());
if (timeOfCalculations <= 0 || timeOfCalculations > 1000)
{ Console.WriteLine("Wrong number!"); return; }

// Integers
int doctors = 7;
int treatedPatients = 0;
int untreatedPatients = 0;

// Calculations

for (int i = 1; i <= timeOfCalculations; i++)
{
    int patientNum = int.Parse(Console.ReadLine());

    if (patientNum < 0 || patientNum > 10000)
    { Console.WriteLine("Wrong number!"); }

    if (i % 3 == 0)
    {
        if (untreatedPatients > treatedPatients)
        {
            doctors++;
        }
    }

    if (patientNum <= doctors)
        treatedPatients += patientNum;
    else if (patientNum > doctors)
    {
        treatedPatients += doctors;
        untreatedPatients += patientNum - doctors;
    }

}

// Output

Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
