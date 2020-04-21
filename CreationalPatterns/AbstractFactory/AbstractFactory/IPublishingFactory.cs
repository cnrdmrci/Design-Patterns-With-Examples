using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractProduct;
using DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteProducts;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.AbstractFactory
{
    public interface IPublishingFactory
    {
        INewspaperProduct CreateNewspaper();
        IBookProduct CreateBook();
    }
}
