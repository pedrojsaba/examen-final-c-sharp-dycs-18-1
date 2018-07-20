using System;

namespace ExamenFinal
{
    public class FacebookSharer : Sharing
    {
        public void Share(string message)
        {
            Console.WriteLine("Message '" + message + "' shared on Facebook");
        }
    }
}