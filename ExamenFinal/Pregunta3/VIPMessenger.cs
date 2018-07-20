using System;

namespace ExamenFinal
{
    class VIPMessenger : Messaging
    {
        public void Send(String Message)
        {
            Console.WriteLine("Message '" + Message + "' sent via P2P");
        }
    }
}
