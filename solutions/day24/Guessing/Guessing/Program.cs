using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessingGame;
using System;

namespace Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var guessMyNumber = new GuessMyNumber();
                var playGame = new PlayTheGame(guessMyNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
