// Input

int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

// Output

Console.WriteLine(RectangleArea(width, length));

// Methods

static int RectangleArea(int width, int length)
{
    int result = width * length;
    return result;
}