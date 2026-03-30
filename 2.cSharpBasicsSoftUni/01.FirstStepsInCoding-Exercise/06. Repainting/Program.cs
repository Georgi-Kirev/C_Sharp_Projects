double Plastic = 1.50;
double Paint = 14.50;
double PaintThinner = 5.00;
double PlasticBags = 0.40;

double PlasticAmount = double.Parse(Console.ReadLine());
double PaintAmount = double.Parse(Console.ReadLine());
double PaintThinnerAmount = double.Parse(Console.ReadLine());
double WorkHours = double.Parse(Console.ReadLine());
double PaintInsurance = 10.0 / 100;

double PlasticAmountTotal = (PlasticAmount + 2) * Plastic;
double PaintAmountTotal = (PaintAmount * (1 + PaintInsurance)) * Paint;
double PaintThinnerAmountTotal = PaintThinnerAmount * PaintThinner;
double TotalAmount = PlasticAmountTotal + PaintAmountTotal + PaintThinnerAmountTotal + PlasticBags;
double WorkPerHouer = 30.0 / 100;
double Workers = (TotalAmount * WorkPerHouer) * WorkHours;
double MaterialsAndWorkhours = TotalAmount + Workers;

Console.WriteLine(MaterialsAndWorkhours);