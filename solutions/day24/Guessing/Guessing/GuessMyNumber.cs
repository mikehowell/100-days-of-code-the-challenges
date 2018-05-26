using System;

namespace GuessingGame
{
    public class GuessMyNumber
    {
        internal int _secretNumber { get; set; }
        public GuessMyNumber()
        {
            Random rnd = new Random();
            _secretNumber = rnd.Next(1, 11);
        }
    }
}
