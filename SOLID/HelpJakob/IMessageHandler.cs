using System;
using System.Collections.Generic;
using System.Text;

namespace HelpJakob
{
    interface IMessageHandler
    {
        void SendMessage(Message message);
        void SendMessageToAll(string[] recievers, Message message);
    }
}
