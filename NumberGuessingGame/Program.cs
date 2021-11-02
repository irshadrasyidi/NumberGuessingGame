using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int numToGuess = r.Next(0, 100);
            bool win = false;
            int tries = 0;

            Console.WriteLine("Guess a number between 0 - 100! ");
            do
            {
                string strInput = Console.ReadLine();
                int intInput = int.Parse(strInput);

                if (intInput > numToGuess)
                {
                    tries++;
                    Console.WriteLine("Too high!! Guess lower..");
                } else if (intInput < numToGuess)
                {
                    tries++;
                    Console.WriteLine("Too low!! Guess higher..");
                } else
                {
                    tries++;
                    Console.WriteLine("Correct!!! You win this game! XDDD\n" +
                        "You guessed the right number with " + tries + " guesses");
                    win = true;
                }
            } while (win == false);

            Console.WriteLine("Thx for playing the game!");
            Console.Write("Press any key to close");
            Console.ReadKey(true);
        }
    }
}
