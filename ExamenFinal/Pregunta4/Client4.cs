using System;

namespace ExamenFinal
{
    class Client4
    {
        static void Main(string[] args)
        {
            SmallBreadSandwich smallBreadSandwich = new SmallBreadSandwich();
            Console.WriteLine(smallBreadSandwich.Make());

            Console.ReadLine();
        }
    }
}
