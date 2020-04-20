using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Product
{
    public abstract class Message
    {
        public abstract string MessageType { get; }
        public abstract string MessageContent { get; }
        public abstract string MessageAddress { get; }
        public abstract void Send();

        public void GetMessageInfo()
        {
            Console.WriteLine(
                "Message Info; \n" +
                $"Message Type     : {MessageType}    \n" +
                $"Message Context  : {MessageContent} \n" +
                $"Message Address  : {MessageAddress} \n" +
                "---------------------------------------------");
        }
    }
}
