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
    public class MessageService
    {
        private readonly Dictionary<MessageSendType, MessageFactory> _factories;
        private readonly MessageSendType _messageSendType;

        private MessageService(MessageSendType messageSendType)
        {
            _factories = new Dictionary<MessageSendType, MessageFactory>
            {
                {MessageSendType.Sms,new SmsFactory() },
                {MessageSendType.Email,new EmailFactory() }
            };

            _messageSendType = messageSendType;
        }

        public static MessageService InitializeFactories(MessageSendType messageSendType) 
            => new MessageService(messageSendType);

        public Message CreateProduct(string messageAddress, string messageContent) 
            => _factories[_messageSendType].CreateMessageProduct(messageAddress, messageContent);
    }
}
