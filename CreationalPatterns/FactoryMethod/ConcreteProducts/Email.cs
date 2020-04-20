using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ConcreteProducts
{
    public class Email : Message
    {
        private readonly string _messageType;
        private string _messageContent;
        private string _messageAddress;

        public Email(string messageAddress, string messageContent)
        {
            _messageType = this.GetType().Name;
            _messageAddress = messageAddress;
            _messageContent = messageContent;
        }

        public override string MessageType { get => _messageType; }
        public override string MessageContent { get => _messageContent; }
        public override string MessageAddress { get => _messageAddress; }

        public override void Send()
        {
            Console.WriteLine(
                "Email Message Send,\n" +
                $"Message Address: {_messageAddress}\n" +
                $"Message Content: {_messageContent}");
        }

    }
}
