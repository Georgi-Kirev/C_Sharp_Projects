// Input
string figure = Console.ReadLine();


string square;
string rectangle;
string circle;
string triangle;

if (figure == "square")
{
    double squareNum = double.Parse(Console.ReadLine());
    double result = squareNum * squareNum;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "rectangle")
{ 
    double rectangleNum = double.Parse(Console.ReadLine());
    double rectangleNum1 = double.Parse(Console.ReadLine());
    double result = rectangleNum * rectangleNum1;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "circle")
{
    double circleNum = double.Parse(Console.ReadLine());
    double result = Math.PI * circleNum * circleNum;
    Console.WriteLine($"{result:F3}");
}
else if (figure == "triangle")
{
    double triangleNum = double.Parse(Console.ReadLine());
    double triangleNum1 = double.Parse(Console.ReadLine());
    double result = (triangleNum * triangleNum1) / 2;
    Console.WriteLine($"{result:F3}");
}