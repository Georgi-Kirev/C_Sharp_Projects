// Input

int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());


for (int i = 0; i < rotations; i++)
{
    int firstNumber = input[0];

    for (int j = 1; j < input.Length; j++)
    {
        input[j - 1] = input[j];
    }

    input[input.Length - 1] = firstNumber;
}


Console.Write(string.Join(" ", input));
