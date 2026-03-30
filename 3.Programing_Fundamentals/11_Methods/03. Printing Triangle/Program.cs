// Input

int N = int.Parse(Console.ReadLine());

// Output

TriangleNumbers(N);


// Methods
static void TriangleNumbers(int N)
{
    // Rows go up
    for (int row = 1; row <= N; row++)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }

    // Rows go down
    for (int row = N - 1; row >= 1; row--)
    {
        for (int col = 1; col <= row; col++)
        {
            Console.Write(col + " ");
        }
        Console.WriteLine();
    }
}
