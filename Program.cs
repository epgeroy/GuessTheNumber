using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Secret secret = new();

            new Game(
                new Attempts(
                    new VerboseDiff(
                        new Diff(
                            new Guess(),
                            secret
                        )
                    ),
                    5
                ),
                secret
            ).Play();
        }
    }
}
