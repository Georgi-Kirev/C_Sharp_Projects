// Kino
// Input
string tipe = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int colloms = int.Parse(Console.ReadLine());
double price = 0;
// Calculations
/*
•	Premiere – премиерна прожекция, на цена 12.00 лева.
•	Normal – стандартна прожекция, на цена 7.50 лева.
•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
*/

switch (tipe)
{
    case "Premiere": price = 12.00; break;
    case "Normal": price = 7.50; break;
    case "Discount": price = 5.00; break;
}

double finalPrice = price * rows * colloms;
// Output
Console.WriteLine($"{finalPrice:F2} leva");