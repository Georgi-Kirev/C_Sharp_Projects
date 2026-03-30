// Input
int juniors = int.Parse(Console.ReadLine());
int seniors = int.Parse(Console.ReadLine());
string typeRoad = Console.ReadLine();

// Integers
double juniorsMoney = 0;
double seniorsMoney = 0;

// Calculations
if (juniors > 0 && typeRoad == "trail")
{
    juniorsMoney = juniors * 5.50;
}
else if (juniors > 0 && typeRoad == "cross-country")
{
    juniorsMoney = juniors * 8;
}
else if (juniors > 0 && typeRoad == "downhill")
{
    juniorsMoney = juniors * 12.25;
}
else if (juniors > 0 && typeRoad == "road")
{
    juniorsMoney = juniors * 20;
}

if (seniors > 0 && typeRoad == "trail")
{
    seniorsMoney = seniors * 7;
}
else if (juniors > 0 && typeRoad == "cross-country")
{
    seniorsMoney = seniors * 9.50;
}
else if (seniors > 0 && typeRoad == "downhill")
{
    seniorsMoney = seniors * 13.75;
}
else if (seniors > 0 && typeRoad == "road")
{
    seniorsMoney = seniors * 21.50;
}

int numParticipants = juniors + seniors;
if (numParticipants >= 50 && typeRoad == "cross-country")
{
    juniorsMoney = juniors * 6;
    seniorsMoney = seniors * 7.125;
}

double totalMoney = juniorsMoney + seniorsMoney;
double expenses = totalMoney - (totalMoney * 0.05); // -5% expenses

// Output
Console.WriteLine($"{expenses:F2}");