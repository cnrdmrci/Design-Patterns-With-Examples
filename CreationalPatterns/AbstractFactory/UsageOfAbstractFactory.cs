using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class UsageOfAbstractFactory
    {
        public static void Run()
        {
            IPublishingFactory publishingFactory = 
                PublishingService
                    .InitializeFactories(PublishingLanguage.English)
                    .CreateProduct();

            Console.WriteLine("Book: " + publishingFactory.CreateBook().GetDetails());
            Console.WriteLine("Book: " + publishingFactory.CreateNewspaper().GetDetails());
        }
    }
}
