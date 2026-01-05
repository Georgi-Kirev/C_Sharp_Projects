double DogFood = 2.50;
double CatFood = 4;

int DogFoodBuyed = int.Parse(Console.ReadLine());
int CatFoodBuyed = int.Parse(Console.ReadLine());

double DogFoodTotal = DogFood * DogFoodBuyed;
double CatFoodTotal = CatFood * CatFoodBuyed;
double TotalFoodBuyed = DogFoodTotal + CatFoodTotal;
Console.WriteLine(TotalFoodBuyed +" lv.");



/*
double DogFood = 2.50;
double CatFood = 4;
Console.WriteLine("Please enter number of DogFood packages:");
int DogFoodBuyed = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter number of CatFood packages:");
int CatFoodBuyed = int.Parse(Console.ReadLine());

double DogFoodTotal = DogFood * DogFoodBuyed;
double CatFoodTotal = CatFood * CatFoodBuyed;
Console.WriteLine($"{CatFoodTotal+DogFoodTotal:F1} lv.");
*/