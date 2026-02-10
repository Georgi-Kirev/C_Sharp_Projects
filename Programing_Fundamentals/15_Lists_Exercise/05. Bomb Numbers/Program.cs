// Input
List<int> sequenceOfInts = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

int[] commands = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int bombNum = commands[0];
int power = commands[1];

while (sequenceOfInts.Contains(bombNum))
{
    int bombIndex = sequenceOfInts.IndexOf(bombNum);

    int leftIndex = Math.Max(0, bombIndex - power);
    int rightIndex = Math.Min(sequenceOfInts.Count - 1, bombIndex + power);

    int count = rightIndex - leftIndex + 1;

    sequenceOfInts.RemoveRange(leftIndex, count);
}

int result = sequenceOfInts.Sum();
Console.WriteLine(result);
