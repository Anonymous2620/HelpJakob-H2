using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob_H2
{
    class VMessageSender : MessageSender
    {
        //Message sent as VMessage
        public override void SendMessage(Message m)
        {
            Console.WriteLine("Message sent as VMessage");
        }
    }
}
