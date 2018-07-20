using System;

namespace ExamenFinal
{
    class SelfDestructingVIPMessenger : VIPMessenger
    {
        public void Send(String Message)
        {
            Message = "☠" + Message + "☠";
            base.Send(Message);
        }
    }
}
