int NumPages = int.Parse(Console.ReadLine());
int ReadHour = int.Parse(Console.ReadLine());
int DaysNum  = int.Parse(Console.ReadLine());

int TotalTimeBook = NumPages / ReadHour;
int HoursDaily = TotalTimeBook / DaysNum;
Console.WriteLine(HoursDaily);