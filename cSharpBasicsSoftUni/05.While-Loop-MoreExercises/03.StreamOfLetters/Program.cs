// Input
string currentWord = "";
string result = "";

bool hasC = false;
bool hasO = false;
bool hasN = false;


while (true)
{
    string input = Console.ReadLine();

    if (hasC && hasO && hasN) // Проверяваме дали имаме цялата тайна команда
    {
        result += currentWord + " "; // Добавяме натрупаната дума и интервал

        currentWord = ""; // Зануляваме текущата дума и флаговете
        hasC = false;
        hasO = false;
        hasN = false;
    }
    if (input == "End") // Ако е въведена команда за край
    {
        break;
    }

    if (string.IsNullOrEmpty(input)) continue; // Проверява дали не е въведено нищо (ако е празен реда)


    char ch = input[0];

    if (!char.IsLetter(ch)) continue; // Пропускаме не-буквени символи



    if (ch == 'c' && !hasC) // Обработка на първо срещане на тайната команда
    {
        hasC = true;
        continue;
    }
    else if (ch == 'o' && !hasO)
    {
        hasO = true;
        continue;
    }
    else if (ch == 'n' && !hasN)
    {
        hasN = true;
        continue;
    }

    currentWord += ch; // Добавяме символ към текущата дума
}

// Ако сме срещнали тайната команда, но още не сме отпечатали думата
if (hasC && hasO && hasN && currentWord.Length > 0)
{
    result += currentWord + " ";
}

Console.WriteLine(result);
