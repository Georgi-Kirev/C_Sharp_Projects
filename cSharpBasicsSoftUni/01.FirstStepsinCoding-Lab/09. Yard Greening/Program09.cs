double Kvadratura = double.Parse(s: Console.ReadLine());
double PriceSquare = 7.61;
double Discount = 0.18;
double TotalPrice = Kvadratura * PriceSquare;
double TotalDiscount = Discount * TotalPrice;
double TotalPriceAfterDiscount = TotalPrice - TotalDiscount;

Console.WriteLine($"The final price is: " +  TotalPriceAfterDiscount + " lv.");
Console.WriteLine($"The discount is: " + TotalDiscount + " lv.");