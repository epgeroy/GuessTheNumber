namespace GuessTheNumber
{
    public class Diff
    {
        private readonly Guess _guess;
        private readonly Secret _secret;

        public Diff(Guess guess, Secret secret)
        {
            _guess = guess;
            _secret = secret;
        }

        public int Number()
        {
            return _guess.Number() - _secret.Number();
        }

    }
}