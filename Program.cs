namespace GuessTheNumber
{
    public static class Program
    {
        public static void Main()
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
