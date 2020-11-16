using System;
using System.Dynamic;

namespace Hjælp_Jakob
{
    class Program
    {
        static void Main(string[] args)
        {
            Message m = new Message("Casper", "Kenneth", "This is a body yes yes", "big important subject", "Jack");
            Send s = new Send();
            s.SendMessage(Send.MessageCarrier.Smtp, m, true, new Converter());
            Console.ReadKey();
        }
    }
}
