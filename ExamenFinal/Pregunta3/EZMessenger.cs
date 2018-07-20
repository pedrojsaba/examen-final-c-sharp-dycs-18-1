using System;

namespace ExamenFinal
{
    class EZMessenger : Messaging
    {
        public void Send(string Message)
        {
            Console.WriteLine("Message '" + Message + "' sent via EZ");
        }
    }
}
