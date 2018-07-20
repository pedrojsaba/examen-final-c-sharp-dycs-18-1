using System;

namespace ExamenFinal
{
    class QuickMessenger : Messaging
    {
        public void Send(string Message)
        {
            Console.WriteLine("Message '" + Message + "' sent via e-mail");
        }
    }
}
