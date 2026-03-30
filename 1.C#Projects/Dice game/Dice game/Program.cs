using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int в случая по-долу се използва за създаването на "контейнер" или референтна стойност
             * която е с определено име тоест int + име и после в кода се ползва това име/дефиниция */
            int PlayerRandomNum;
            int EnemyRandomNum;

            int PlayerPoints = 0;
            int EnemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++) // FOR в случая се използва за да се повтори 10 пъти кода 
            {
                Console.WriteLine("Press any key to roll the dice.");
                Console.ReadKey();

                PlayerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + PlayerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(500); //Използва се за забавяне на времето преди показване 500милисекунди

                EnemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Your enemy rolled a " + EnemyRandomNum);

                if (PlayerRandomNum > EnemyRandomNum)
                {
                    PlayerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (EnemyRandomNum > PlayerRandomNum)
                {
                    EnemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else 
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine();
                Console.WriteLine("The score is now - Player : " + PlayerPoints);
                Console.WriteLine("The score is now - Enemy : " + EnemyPoints);
            }

            if (PlayerPoints > EnemyPoints)
            {
                Console.WriteLine("Player WINS");
            }
            if (EnemyPoints > PlayerPoints) 
            {
                Console.WriteLine("Enemy WINS"); 
            }
            else
            {
                Console.WriteLine("Draw Better luck next time to all");
            }   

                Console.ReadKey();

        }
    }
}
