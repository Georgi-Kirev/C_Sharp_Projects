// 2.Centuries to Minutes

int century = int.Parse(Console.ReadLine());

int years = century * 100;
double days = Math.Round(years * 365.2422);
double hours = days * 24;
double minutes = hours * 60;



Console.WriteLine($"{century} centuries = {years} years = {days:F0} days = {hours:F0} hours = {minutes:F0} minutes");