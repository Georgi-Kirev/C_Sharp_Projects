double InsertedAmount = double.Parse(Console.ReadLine());
int Months = int.Parse(Console.ReadLine());
double InterestRateNum = double.Parse(Console.ReadLine());
double InterestRate = InterestRateNum / 100;
double InterestRateAfterTime = InsertedAmount * InterestRate;
double InterestRateMonth = InterestRateAfterTime / 12;
double result = InsertedAmount + Months * InterestRateMonth;
Console.WriteLine(result);