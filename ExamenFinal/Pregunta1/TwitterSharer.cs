using System;

namespace ExamenFinal
{
    public class TwitterSharer : Sharing
    {
        public void Share(string message)
        {
            Console.WriteLine("Message '" + message + "' shared on Twitter");
        }
    }
}