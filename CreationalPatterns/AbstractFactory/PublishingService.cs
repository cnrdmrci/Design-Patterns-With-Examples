using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public enum PublishingLanguage
    {
        English,
        Russian
    }
    public class PublishingService
    {
        private readonly PublishingLanguage _publishingLanguage;
        private readonly Dictionary<PublishingLanguage, IPublishingFactory> _factories;
        public PublishingService(PublishingLanguage publishingLanguage)
        {
            _factories = new Dictionary<PublishingLanguage, IPublishingFactory>
            {
                {PublishingLanguage.English,new EnglishFactory() },
                {PublishingLanguage.Russian,new RussianFactory() }
            };
            _publishingLanguage = publishingLanguage;
        }

        public static PublishingService InitializeFactories(PublishingLanguage publishingLanguage) 
            => new PublishingService(publishingLanguage);

        public IPublishingFactory CreateProduct() => _factories[_publishingLanguage];
    }
}
