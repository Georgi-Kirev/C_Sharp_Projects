double ChikenMenu = 10.35;
double FishMenu = 12.40;
double VegitarianMenu = 8.15;
double DesertCost = 0.20;
double Delivery = 2.50;

int ChikenMenuNum = int.Parse(Console.ReadLine());
int FishMenuNum = int.Parse(Console.ReadLine());
int VegitarianMenuNum = int.Parse(Console.ReadLine());

double ChikenMenuAmmount = ChikenMenuNum * ChikenMenu;
double FishMenuAmmount = FishMenuNum * FishMenu;
double VegitarianMenuAmmount = VegitarianMenuNum * VegitarianMenu;
double BillwithoutDelivery = (ChikenMenuAmmount+ FishMenuAmmount + VegitarianMenuAmmount )* (1 + DesertCost);
double Bill = (BillwithoutDelivery + Delivery);
Console.WriteLine(Bill);