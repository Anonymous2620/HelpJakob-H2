using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpJakob_H2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test messages
            MessageHandler handler = new MessageHandler();
            Message message = new Message("test", "test", "test", "test", "test");


            //Array of people recieving a message
            string[] to =
            {
                "Nicole",
                "James"
            };

            //Sends message to the people above in the array
            handler.HandleMassage(to, message, true, MessageCarrier.Smtp);

            Console.ReadKey();
        }
    }
}
