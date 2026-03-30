double Pens = 5.80;
double Markers = 7.20;
double Chemical = 1.20;

double PensBouth = double.Parse(Console.ReadLine());
double MarkersBouth = double.Parse(Console.ReadLine());
double LitersChemical = double.Parse(Console.ReadLine());
double Discount = double.Parse(Console.ReadLine());
double DiscountPercent = Discount / 100;

double TotalPens = (double)(PensBouth * Pens);
double TotalMarkers = (double)(MarkersBouth * Markers);
double TotalChemical = (double)(LitersChemical * Chemical);

double TotalPriceNoDiscount = (double)(TotalPens + TotalMarkers + TotalChemical);
double TotalPrice = (double)(TotalPriceNoDiscount) - (TotalPriceNoDiscount * DiscountPercent);

Console.WriteLine(TotalPrice);