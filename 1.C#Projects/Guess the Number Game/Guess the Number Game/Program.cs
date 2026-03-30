using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to Number guessing game");
            Console.WriteLine("Number from 1 to 10 will be generated.");
            Console.WriteLine("If you guess the correct number, you win!");

            
            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low");
                   
                }
                else
                {
                    Console.WriteLine("Congratulation you WIN");
                    isCorrectGuess = true;
                }
            }
            Console.ReadKey();

        }
    }
}
