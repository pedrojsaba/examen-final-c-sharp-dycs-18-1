using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class SelfDestructingEZMessenger : EZMessenger
    {
        public void Send(String Message)
        {
            Message = "☠" + Message + "☠";
            base.Send(Message);
        }
    }
}
