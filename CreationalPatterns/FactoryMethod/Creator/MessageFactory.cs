using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.Creator
{
    public abstract class MessageFactory
    {
        protected abstract Message MakeMessageProduct(string messageAddress, string messageContent);

        public Message CreateMessageProduct(string messageAddress, string messageContent) 
            => MakeMessageProduct(messageAddress, messageContent);
    }
}
