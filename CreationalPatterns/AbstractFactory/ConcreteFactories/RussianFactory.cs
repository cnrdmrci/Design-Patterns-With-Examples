using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteProducts
{
    public class RussianFactory : IPublishingFactory
    {
        public INewspaperProduct CreateNewspaper()
        {
            return new RussianNewspaper();
        }

        public IBookProduct CreateBook()
        {
            return new RussianBook();
        }
    }
}
