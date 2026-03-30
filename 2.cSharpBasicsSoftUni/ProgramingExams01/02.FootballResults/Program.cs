
        // Input
        int Won = 0, Lost = 0, Drawn = 0;

        // Calculations
        for (int i = 1; i <= 3; i++)
        {
            string input = Console.ReadLine(); // Пример: 3:1 0:2 0:0 
            string[] parts = input.Split(':');

            int homeGoals = int.Parse(parts[0]);
            int awayGoals = int.Parse(parts[1]);

            if (homeGoals > awayGoals)
                Won++;
            else if (homeGoals < awayGoals)
                Lost++;
            else
                Drawn++;
        }

        // Output
        Console.WriteLine($"Team won {Won} games.");
        Console.WriteLine($"Team lost {Lost} games.");
        Console.WriteLine($"Drawn games: {Drawn}");































/*
// Input
double FirstMatch = double.Parse(Console.ReadLine());
double SecondMatch = double.Parse(Console.ReadLine());
double ThirdMatch = double.Parse(Console.ReadLine());

// Broqchi

int Won = 0;
int Lost = 0;
int Drawn = 0;

List<double> DrawnList = new List<double> { 0:0,1:1,2:2,3:3,4:4,5:5,6:6,7:7,8:8,9:9,10:10};
// Calculation

if (DrawnList.Contains(FirstMatch))
{
    Drawn++;
}
else if (FirstMatch >= 1:0)
{
    Won++;
}
else
{ 
    Lost++;
}


if (DrawnList.Contains(SecondMatch))
{
    Drawn++;
}
else if (SecondMatch >= 1:0)
{
    Won++;
}
else
{
    Lost++; 
}

if (DrawnList.Contains(ThirdMatch))
{
    Drawn++;
}
else if (ThirdMatch >= 1:0)
{
    Won++;
}
else
{ 
    Lost++;
}
// Output

Console.WriteLine("Team won " + Won);
Console.WriteLine("Team lost " + Lost);
Console.WriteLine("Team Drawn " + Drawn);
*/