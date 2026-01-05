// Input
double tour = double.Parse(Console.ReadLine()); // цена на екскурзията
int pN = int.Parse(Console.ReadLine()); // pN = Брой на пъзелите
int sDollsN = int.Parse(Console.ReadLine()); //sDollsN = брой говорещи кукли
int pBearsN = int.Parse(Console.ReadLine()); // pBearsN = плюшени мечета
int minionsN = int.Parse(Console.ReadLine());
int trucksN = int.Parse(Console.ReadLine());

// Variables
double puzzle = 2.60;
double speakingDolls = 3;
double pBears = 4.10;
double minionsP = 8.20;
double trucksP = 2;

// Calculations
double puzzleNum = pN * puzzle;
double speakingDollsNum = sDollsN * speakingDolls;
double bearsNum = pBearsN * pBears;
double minionsNum = minionsN * minionsP;
double trucksNum = trucksN * trucksP;
double totalNumProducts = pN + sDollsN + pBearsN + minionsN + trucksN;
double totalPrice = puzzleNum + speakingDollsNum + bearsNum + minionsNum +  trucksNum;

if (totalNumProducts >= 50)
{ 
    totalPrice -= (totalPrice * 0.25);
} 
    

double totalPricePlusRent = totalPrice - (totalPrice * 0.1);

// Output

if (totalPricePlusRent >= tour)
{
    double moneyLeft = totalPricePlusRent - tour;
    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
}
else
{
    double moneyNeeded = tour - totalPricePlusRent;
    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
}