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

            if (number < 0)
            {
                System.Console.WriteLine("Too low.");
            }
            else if (number > 0)
            {
                System.Console.WriteLine("Too high.");
            }
            else
            {
                System.Console.WriteLine("Bingo!");
            }

            return number;
        }
    }
}