// For the summer holidays, there are a certain number of books on Joro's list of mandatory literature. Since Joro prefers to play with friends outside, your task is to help him calculate how many hours a day he should devote to reading the necessary literature.
// Input:

int numberOfPages = int.Parse(Console.ReadLine());
int pagesReadPerHour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());

// Calculation:
int totalHoursNeeded = numberOfPages / pagesReadPerHour;
int totalDaysNeeded = totalHoursNeeded / numberOfDays;

// Output:
Console.WriteLine(totalDaysNeeded);