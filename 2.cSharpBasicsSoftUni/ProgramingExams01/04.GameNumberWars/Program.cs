// 04. Game Number Wars
// Inputs
string namePlayer1 = Console.ReadLine();
string namePlayer2 = Console.ReadLine();

// Integers
// MAX numbers of cards in this game is 36 in total.18-per player
int player1Points = 0;
int player2Points = 0;

// Calculations

while (player1Points < player2Points && player2Points > player1Points)
{
    int Player1 = int.Parse(Console.ReadLine());
    int Player2 = int.Parse(Console.ReadLine());

    if (Player1 >= 10 && Player2 >= 10)
    {
        Console.WriteLine("Invalid Number.Please enter number 2-9.");
        Player1 = int.Parse(Console.ReadLine());
        Player2 = int.Parse(Console.ReadLine());
    }
    else if (Player1 <= 1 && Player2 <= 1)
    {
        Console.WriteLine("Invalid Number.Please enter number 2-9.");
        Player1 = int.Parse(Console.ReadLine());
        Player2 = int.Parse(Console.ReadLine());
    }

    if (Player1 > Player2)
    {
        player1Points++;
    }
    else if (Player1 < Player2)
    {
        player2Points++;
    }
    else if (Player1 == Player2)
    {
        Console.WriteLine("Number wars!");

        // Second try
        int Player1Sec = int.Parse(Console.ReadLine());
        int Player2Sec = int.Parse(Console.ReadLine());

        if (Player1Sec >= 10 && Player2Sec >= 10)
        {
            Console.WriteLine("Invalid Number.Please enter number 2-9.");
            Player1 = int.Parse(Console.ReadLine());
            Player2 = int.Parse(Console.ReadLine());
        }
        else if (Player1Sec <= 1 && Player2Sec <= 1)
        {
            Console.WriteLine("Invalid Number.Please enter number 2-9.");
            Player1 = int.Parse(Console.ReadLine());
            Player2 = int.Parse(Console.ReadLine());
        }

        if (Player1Sec > Player2Sec)
        {
            player1Points++;
        }
        else if (Player1Sec < Player2Sec)
        {
            player2Points++;
        }
        else if (Player1Sec == Player2Sec)
        {
            Console.WriteLine("Number wars!");

        }
    }
}
// Winner
if (Player1 = "End of game" && Player2 = "End of game")
{
    Console.WriteLine($"{namePlayer1} has {player1Points} points");
}// трябва да се направи така ,че ако играчите въведат end of game да изпише резултата и да спре
 // да се довърши Number wars като стане да изпише и кой колко печели.