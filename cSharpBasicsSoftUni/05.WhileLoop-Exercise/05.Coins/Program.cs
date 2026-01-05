// Input
double money = double.Parse(Console.ReadLine());
int counter = 0;
int money2 = (int)(money * 100);  // закръгляне до стотинки

while (money2 > 0)
{
    if (money2 >= 200) money2 -= 200;
    else if (money2 >= 100) money2 -= 100;
    else if (money2 >= 50) money2 -= 50;
    else if (money2 >= 20) money2 -= 20;
    else if (money2 >= 10) money2 -= 10;
    else if (money2 >= 5) money2 -= 5;
    else if (money2 >= 2) money2 -= 2;
    else if (money2 >= 1) money2 -= 1;

    counter++;
}

Console.WriteLine(counter);
