// Input 

int[] firstArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
bool areSame = true;

// Checks

if (firstArray.Length == secondArray.Length)
{
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i] != secondArray[i])
        {
            areSame = false;
            break;
        }
    }
}
else
{
    areSame = false;
}

// Output

if (areSame == true)
{
    Console.WriteLine("Arrays are identical.");
}
else
{
    Console.WriteLine("Arrays are not identical.");
}
