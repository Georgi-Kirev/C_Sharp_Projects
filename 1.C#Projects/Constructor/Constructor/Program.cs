using System;
using System.ComponentModel;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Конструктор е Наименованието на Class (или блупринта) като в случая на този файл това е 'Program'.
            // Имам и Class Students също като "Students" е Конструктор.
            /* Това е втори варянт в който може да се пишат коментари на няколко греда 
             * горният пример с двете // с него може да се пишат само на 1 ред
             * а с този на повече от 1 ред */

            Students Students1 = new Students("Georgi", "Kirev", 35, 175, 80);
            Console.WriteLine(Students1.HasHight());
            Console.WriteLine(Students1.FirstName);

            Students Students2 = new Students("Plamena", "Kireva", 33, 170, 72);
            Console.WriteLine(Students2.HasHight());
            Console.WriteLine(Students2.FirstName);

            Students Students3 = new Students("Borislav", "Kirilov", 43, 177, 90);
            Console.WriteLine(Students3.HasHight());
            Console.WriteLine(Students3.FirstName);

            Students Students4 = new Students("Sneja", "Miteva", 42, 168, 65);
            Console.WriteLine(Students.StudentsNum);
            Console.WriteLine(Students4.HasHight());
            Console.WriteLine(Students4.FirstName);
            
            Console.WriteLine(Students4.Lastname);
         /* Console.WriteLine(Students2.LastName); !!! Lastname с малко 'n' работи понеже в класа Students е направено условие
          * при което LastName се изписва само ако е въведена думата с главна първа буква и малки останалите " if (value == "Lastname") " */

            
            Console.ReadLine();
        }
    }
}
