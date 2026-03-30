// Input

int number = int.Parse(Console.ReadLine());

// Check

if (number >= 0 && number <= 3)
    number += 5;
else if (number >= 4 && number <= 6)
    number += 15;
else if (number >= 7 && number <= 9)
    number += 20;

// Output

Console.WriteLine(number);

