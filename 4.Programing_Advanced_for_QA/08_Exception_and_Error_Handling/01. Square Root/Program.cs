// Input

double squareRoot = double.Parse(Console.ReadLine());


try
{
    if (squareRoot < 0)
    {
        throw new ArithmeticException();
    }
    else
    {
        double calculatedNum = Math.Sqrt(squareRoot);
        Console.WriteLine(calculatedNum);
    }

}
catch (ArithmeticException)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}