namespace GuessTheNumber
{
    public class Game
    {
        private readonly Secret _secret;
        private readonly Attempts _attempts;

        public Game(Attempts attempts, Secret secret)
        {
            _attempts = attempts;
            _secret = secret;
        }

        public void Play()
        {
            if (!_attempts.Matches())
            {
                System.Console.WriteLine($"The number was {_secret.Number()}");
                System.Console.WriteLine("Game Over.");
            }

            System.Console.WriteLine("Thanks for playing!");
        }
    }
}