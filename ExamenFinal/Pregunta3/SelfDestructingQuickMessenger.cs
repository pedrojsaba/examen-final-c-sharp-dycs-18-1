using System;

namespace ExamenFinal
{
    class SelfDestructingQuickMessenger : QuickMessenger
    {
        public void Send(String Message)
        {
            Message = "☠" + Message + "☠";
            base.Send(Message);
        }
    }
}
