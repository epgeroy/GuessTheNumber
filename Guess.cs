using System;

namespace GuessTheNumber
{
    public class Guess
    {
        public int Number ()
        {
            Console.WriteLine("Guess the number between 0 and 100");
            return Convert.ToInt32(
                Console.ReadLine()
            );
        }
    }
}