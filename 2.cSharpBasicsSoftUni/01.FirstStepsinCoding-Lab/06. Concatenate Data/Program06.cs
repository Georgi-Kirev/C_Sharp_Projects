string FirstName = Console.ReadLine();
string LastName = Console.ReadLine();
int Age = int.Parse(Console.ReadLine());
string City = Console.ReadLine();

Console.WriteLine($"You are {FirstName} {LastName}, a {Age}-years old person from {City}.");


/* Tipe casting или какво се принтира
 * когато пресмятаме числа и използваме int ,double или друго е важно да знаем следното
 * int * int = int
 * int * double = double
 * double * int = double
 * double * double = double
 * важно е да се знае ,че на 0 не може да се дели и дава грешка 
 * понеже в командата по-горе int нямаме знак за безкрайност.Това се прави с double или друга.
 * ако делим 0 на 0 получаваме NaN (not a number) или това не е число
 */

//команди за навигиране CTRL + Z = Undo ; CTRL + Y = Redo