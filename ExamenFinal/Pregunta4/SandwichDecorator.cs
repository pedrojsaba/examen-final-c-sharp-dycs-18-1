using System;

namespace ExamenFinal
{
    public class SandwichDecorator : Sandwich
    {
        private readonly Sandwich sandwich;

        SandwichDecorator(Sandwich pizza)
        {
            sandwich = sandwich;
        }

        public string Make()
        {
            throw new NotImplementedException();
        }
    }
}
