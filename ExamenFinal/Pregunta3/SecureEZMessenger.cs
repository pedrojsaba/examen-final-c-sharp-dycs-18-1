using System;

namespace ExamenFinal
{
    class SecureEZMessenger : EZMessenger
    {
        private String Encrypt(String Message)
        {
            Message = Message.Substring(Message.Length - 1) + Message.Substring(0, Message.Length - 1);
            return Message;
        }

        public void Send(String Message)
        {
            Message = Encrypt(Message);
            base.Send(Message);
        }
    }
}
