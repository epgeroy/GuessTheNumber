namespace GuessTheNumber
{
    public class Attempts
    {
        private readonly VerboseDiff _diff;
        private readonly int _max;

        public Attempts(VerboseDiff diff, int max)
        {
            _diff = diff;
            _max = max;
        }

        public bool Matches()
        {
            int currentTry = 0;
            while (currentTry <= _max && _diff.Number() != 0)
            {
                currentTry ++;
            }

            return currentTry <= _max;
        }

    }
}