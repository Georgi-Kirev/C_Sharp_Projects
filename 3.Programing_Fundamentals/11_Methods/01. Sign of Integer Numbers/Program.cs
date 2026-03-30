// Input

int N = int.Parse(Console.ReadLine());

// Methods

static void NisBiggerThanZero(int N)
{
    Console.WriteLine($"The number {N} is positive.");
}

static void NisSmallerThanZero(int N)
{
    Console.WriteLine($"The number {N} is negative.");
}

static void NisEqualToZero(int N)
{
    Console.WriteLine($"The number {N} is zero.");
}

// Checks and outputs

if (N > 0)
{
    NisBiggerThanZero(N);
}
else if (N < 0)
{
    NisSmallerThanZero(N);
}
else
    NisEqualToZero(N);