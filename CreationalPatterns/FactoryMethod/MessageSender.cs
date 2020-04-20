using System;
using System.Collections.Generic;
using DesignPatterns.CreationalPatterns.FactoryMethod.ConcreteCreators;
using DesignPatterns.CreationalPatterns.FactoryMethod.Creator;
using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public enum MessageSendType
    {
        Sms,
        Email
    }
    public class MessageSender
    {
        private readonly Dictionary<MessageSendType, MessageFactory> _factories;
        private readonly MessageSendType _messageSendType;

        private MessageSender(MessageSendType messageSendType)
        {
            _factories = new Dictionary<MessageSendType, MessageFactory>
            {
                {MessageSendType.Sms,new SmsFactory() },
                {MessageSendType.Email,new EmailFactory() }
            };

            _messageSendType = messageSendType;
        }

        public static MessageSender InitializeFactories(MessageSendType messageSendType) 
            => new MessageSender(messageSendType);

        public Message CreateProduct(string messageAddress, string messageContent) 
            => _factories[_messageSendType].CreateMessageProduct(messageAddress, messageContent);
    }
}
