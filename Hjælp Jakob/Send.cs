using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Jakob
{

    //This class is responsible of sending messages
    class Send
    {
        public enum MessageCarrier { Smtp, VMessage }

        public void SendMessage(MessageCarrier type, Message m, bool isHTML, Converter c)
        {
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }

        public void SendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML, Converter c)
        {
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = c.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
