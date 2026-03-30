// Input
int numOpenTabs = int.Parse(Console.ReadLine());
int salary = int.Parse(Console.ReadLine());

// Output
for (int i = 0; i < numOpenTabs; i++)
{
    string tabName = Console.ReadLine();

    // Deduct salary based on tab name
    switch (tabName)
    {
        case "Facebook":
            salary -= 150;
            break;
        case "Instagram":
            salary -= 100;
            break;
        case "Reddit":
            salary -= 50;
            break;
    }
}

// Check if salary is below or equal to zero
if (salary <= 0)
{
    Console.WriteLine("You have lost your salary.");
}
else
{
    Console.WriteLine(salary);
}