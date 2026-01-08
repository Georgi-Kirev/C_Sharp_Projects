// Program that calculates how much you will receive at the end of the deposit period at a certain interest rate

// Input:
double depositedAmount = double.Parse(Console.ReadLine());
int termOfDeposit = int.Parse(Console.ReadLine());
double annualInterestRate = double.Parse(Console.ReadLine());

//Calculation:
double amount = depositedAmount + termOfDeposit * (depositedAmount * annualInterestRate / 100) / 12;

// Output:
Console.WriteLine($"{amount:F2}");