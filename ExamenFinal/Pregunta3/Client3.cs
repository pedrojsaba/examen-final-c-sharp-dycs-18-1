using System;

namespace ExamenFinal
{
    class Client3
    {
        static void Main(string[] args)
        {
            String Message = "Hello";

            QuickMessenger quickMessenger = new QuickMessenger();
            quickMessenger.Send(Message);

            SecureQuickMessenger secureQuickMessenger = new SecureQuickMessenger();
            secureQuickMessenger.Send(Message);

            SelfDestructingQuickMessenger selfDestructingQuickMessenger = new SelfDestructingQuickMessenger();
            selfDestructingQuickMessenger.Send(Message);

            VIPMessenger vipMessenger = new VIPMessenger();
            vipMessenger.Send(Message);

            SecureVIPMessenger secureVIPMessenger = new SecureVIPMessenger();
            secureVIPMessenger.Send(Message);

            SelfDestructingVIPMessenger selfDestructingVIPMessenger = new SelfDestructingVIPMessenger();
            selfDestructingVIPMessenger.Send(Message);

            EZMessenger ezMessenger = new EZMessenger();
            ezMessenger.Send(Message);

            SecureEZMessenger secureEZMessenger = new SecureEZMessenger();
            secureEZMessenger.Send(Message);

            SelfDestructingEZMessenger selfDestructingEZMessenger = new SelfDestructingEZMessenger();
            selfDestructingEZMessenger.Send(Message);

            Console.ReadLine();
        }
    }
}
