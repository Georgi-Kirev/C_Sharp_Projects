using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Combat_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 40;
            int enemyHP = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHP > 0 && enemyHP > 0)
            {
                // Player turn
                Console.WriteLine("-- Player turn --");
                Console.WriteLine("Enter 'a' to attack or 'h' to Heal.");

                string choise = Console.ReadLine();

                if (choise == "a")
                {
                    enemyHP -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage");
                    Console.WriteLine("Player health is now " + playerHP);
                }

                else
                {
                    playerHP += healAmount;
                    Console.WriteLine("Player restore " + healAmount + " health points!");
                    Console.WriteLine("Player health is now " + playerHP);
                }

                //Enemy turn
                if (enemyHP > 0)
                {
                    Console.WriteLine("-- Enemy turn --");
                    int enemyChoise = random.Next(0, 2);

                    if (enemyChoise == 0)
                    {
                        playerHP -= enemyAttack;
                        Console.WriteLine("Enemy attack Player and deals " + enemyAttack + " damage");
                        Console.WriteLine("Enemy health is now " + enemyHP);
                    }
                    else
                    {
                        enemyHP += healAmount;
                        Console.WriteLine("Enemy restore " + healAmount + " health points!");
                        Console.WriteLine("Enemy health is now " + enemyHP);
                    }
                }

            }

            if (playerHP > 0 && enemyHP <= 0)
            {
                Console.WriteLine("Congratulations Player WINS!!!");
            }
            else
            {
                Console.WriteLine("Congratulations Enemy WINS!!!");
            }

            Console.ReadLine();
        }
            
        
    }
}
