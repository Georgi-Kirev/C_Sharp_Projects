// Input
double TenisRacketPrice = double.Parse(Console.ReadLine());
int TenisRacketsNum = int.Parse(Console.ReadLine());
int Sneakers = int.Parse(Console.ReadLine());

// Calculation
double TotalRacketPrice = TenisRacketPrice * TenisRacketsNum;
double SneakersPrice = TenisRacketPrice / 6;
double TotalSneakersPrice = Sneakers * SneakersPrice;

double EquipmentTotal = TotalRacketPrice + TotalSneakersPrice;
double AdditionalCosts = EquipmentTotal * 0.2;
double FinalTotal = EquipmentTotal + AdditionalCosts;

double PriceForDjokovic = FinalTotal / 8;
double PriceForSponsors = FinalTotal * 7 / 8;

// Output
Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(PriceForDjokovic)}");
Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(PriceForSponsors)}");
