double PY = double.Parse(Console.ReadLine()); //PY = Price for 1 Year
double Shoes = PY -(PY * 0.40); //0.40 = 40%  (formula 40% / 100 = 0.40)
double Outfit = Shoes - (Shoes * 0.20); //0.20 = 20%  (formula 20% / 100 = 0.20)
double Ball = Outfit / 4;
double Acc = Ball / 5; //Acc = Accessories
double TotalPY = PY+Shoes+Outfit+Ball+Acc;
Console.WriteLine(TotalPY);