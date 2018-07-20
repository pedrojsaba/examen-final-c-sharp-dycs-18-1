using System;

namespace ExamenFinal
{
    class Client1
    {
        static void Main(string[] args)
        {
            Sharer sharer = new Sharer();
            sharer.Share("Mastering design patterns", SharerType.Facebook);
            sharer.ShareEveryWhere("I'll receive my Master's degree from UNMSM very soon");
            Console.ReadLine();
        }
    }
}
