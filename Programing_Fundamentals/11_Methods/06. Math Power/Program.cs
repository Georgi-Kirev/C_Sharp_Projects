// Input

int baseNum = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());


// Display

RaiseNumber(baseNum, powerNum);

// Methods

static void RaiseNumber(int baseNum, int powerNum)
{
    Console.WriteLine(Math.Pow(baseNum, powerNum));
}