namespace GuessTheNumber
{
    public class VerboseDiff
    {
        private readonly Diff _diff;

        public VerboseDiff(Diff diff)
        {
            _diff = diff;
        }

        public int Number()
        {
            int number = _diff.Number();

            switch (number)
            {
                case < 0:
                    System.Console.WriteLine("Too low.");
                    break;
                case > 0:
                    System.Console.WriteLine("Too high.");
                    break;
                default:
                    System.Console.WriteLine("Bingo!");
                    break;
            }

            return number;
        }
    }
}