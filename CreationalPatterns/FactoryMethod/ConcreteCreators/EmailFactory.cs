using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.FactoryMethod.ConcreteProducts;
using DesignPatterns.CreationalPatterns.FactoryMethod.Creator;
using DesignPatterns.CreationalPatterns.FactoryMethod.Product;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.ConcreteCreators
{
    public class EmailFactory : MessageFactory
    {
        protected override Message MakeMessageProduct(string messageAddress, string messageContent) 
            => new Email(messageAddress, messageContent);
    }
}
