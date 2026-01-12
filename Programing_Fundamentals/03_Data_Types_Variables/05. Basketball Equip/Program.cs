// Inputs:

int fee = int.Parse(Console.ReadLine());

// Calculation:

double sneakers = fee * 0.6;
double uniform = sneakers * 0.8;
double ball = uniform / 4;
double accessories = ball / 5;

// Output:

Console.WriteLine(fee + sneakers + uniform + ball + accessories);