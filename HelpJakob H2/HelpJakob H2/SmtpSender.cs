using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob_H2
{
    class SmtpSender : MessageSender
    {
        //Message sent as Smtp
        public override void SendMessage(Message m)
        {
            Console.WriteLine("Message sent as Smtp");
        }
        
    }
}
