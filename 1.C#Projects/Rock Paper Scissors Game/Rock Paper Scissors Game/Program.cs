using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors game");

            while (playerScore != 3 &&  enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + " Enemy score " + enemyScore);
                Console.WriteLine("Please enter 'r' for Rock , 'p' for Paper or anything for scissors");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses 'Rock'");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("TIE!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this ROUND");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this ROUND");
                            enemyScore++;
                            break;

                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses 'Paper'");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this ROUND");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("TIE!");
                            break;
                        default:
                            Console.WriteLine("Player wins this ROUND");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses 'Scissors'");

                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this ROUND");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins this ROUND");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("TIE!");
                            break;
                    }
                }
            }

            if (playerScore == 3)
            {
                Console.WriteLine("Player WINS!");
            }
            else
            {
                Console.WriteLine("Enemy WINS!");
            }
        }
    }
}
