using System;
namespace GuessTheNumber
{
    public class Secret
    {
        private readonly int _number;
        public int Number ()
        {
            return _number;
        }

        public Secret() :
            this(
                new Random()
                    .Next(
                        0, 100
                    )
            )
        { }
        protected Secret(int number)
        {
            _number = number;
        }
    }
}