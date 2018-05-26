using System;

namespace GuessingGame
{
    public class PlayTheGame
    {
        private int _userGuess = 0;
        public PlayTheGame(GuessMyNumber randomNumber)
        {
            for (int i = 3; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine("Guess a number between 1 and 10.\r\nYou have {0} attempts!", i);
                string userGuess = Console.ReadLine();

                if (string.IsNullOrEmpty(userGuess))
                {
                    throw new ArgumentNullException("input cannot be null or empty");
                }

                bool validInput = int.TryParse(userGuess, out _userGuess);

                if (!validInput)
                {
                    throw new ArgumentException("input should be a valid number");
                }

                if(_userGuess == randomNumber._secretNumber)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations, you guessed the correct number in {0} goes", 4-i);
                    Console.ReadLine();
                    break;
                }
                else if (i == 1)
                {
                    throw new Exception(String.Format("All out of tries. The number you should have guessed was {0}", randomNumber._secretNumber));
                }
            }
        }
    }
}
