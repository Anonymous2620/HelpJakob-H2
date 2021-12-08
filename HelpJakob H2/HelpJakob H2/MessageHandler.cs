using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob_H2
{  
    class MessageHandler
    {
        MessageSender sender;
        //Sends message
        public void HandleMassage(Message message, bool isHtml, MessageCarrier carrier)
        {
            SetSender(carrier);

            if (isHtml)
                message.Body = Converter.ConvertBodyToHTML(message.Body);

            sender.SendMessage(message);
        }
        //Sends message to string array
        public void HandleMassage(string[] to, Message message, bool isHtml, MessageCarrier carrier)
        {
            SetSender(carrier);

            if (isHtml)
                message.Body = Converter.ConvertBodyToHTML(message.Body);

            foreach (string m in to)
            {
                message.To = m;
                sender.SendMessage(message);
            }
        }

        //Switch case for the MessageSender Stmp or VMessage
        void SetSender(MessageCarrier carrier)
        {
            switch (carrier)
            {
                case MessageCarrier.Smtp:
                    sender = new SmtpSender();
                    break;
                case MessageCarrier.VMessage:
                    sender = new VMessageSender();
                    break;
                default:
                    break;
            }
        }
    }
}
