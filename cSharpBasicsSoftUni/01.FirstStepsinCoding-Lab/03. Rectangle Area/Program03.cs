int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int area = a * b;
Console.WriteLine(area);




/* Типове данни
 * int за цели числа = 1,2,3,4,5,6,7....
 * double за дробни числа = 0.5, 1.5, -3.5, 3.14....
 * string за низ от думи и текст = "Здрасти" "Hi" "Car" ...
 * char за еденични символи използват се еденични кавички !!! = '@' 'A' '#' '+' ... */


/* Задължително ВАЖНО
 * Всичко което се записва или принтира на 'Конзолата' се принтира като ТЕКСТ 
 * дори и да запиша 25 числото като пусна програмата ще пише 25 но компютъра ще го брои като текст не като цифра
 * за да може компютъра та различи конкретна цифра като такаво използваме командите int.Parse(Console.ReadLine());
 * като int е за цели цифри може да е double или друго а Parse е команда при която се взема написаното
 * от в случая на примера Console.ReadLine и го конвертира в цифра ако е възможно
 * тоест при този ред: int.Parse(Console.ReadLine()); ако въведа в конзолата 5 на екрана ще покаже 5 и
 * компютъра ще чете това 5 като цифра и ще мога да правя аритметични задачи с това */

/* !!!!!!!!!!!!!!!! Да попитам така написан кода не е грешен но е неправилен защото няма метода area 
 * както е на примера горе и съответно в случай на по-голям код няма да работи защото няма
 * от къде да се вземе информацията за ареа

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

Console.WriteLine(a * b);

*/
/* по прилежен код според мен
 
Console.WriteLine("Please write first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Please write second number");
int b = int.Parse(Console.ReadLine());

int area = a * b;
Console.WriteLine(area);
*/