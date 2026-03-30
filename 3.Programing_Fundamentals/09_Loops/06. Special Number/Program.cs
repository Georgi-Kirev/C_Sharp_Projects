// Input

int N = int.Parse(Console.ReadLine());
bool itIs = false;
int F = N;
// Check

while (F > 0)
{
    double sum = F % 10;
    if (N % sum == 0)
    {
        itIs = true;
    }
    else if (N % sum != 0)
    {
        itIs = false;
        break;
    }
    F /= 10;

}

if (itIs == true)
{
    Console.WriteLine($"{N} is special");
}
else if (itIs == false)
{
    Console.WriteLine($"{N} is not special");
}