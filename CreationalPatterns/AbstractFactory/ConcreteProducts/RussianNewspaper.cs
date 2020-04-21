using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    public class RussianNewspaper : INewspaperProduct
    {
        public string GetDetails()
        {
            return "Russian Book";
        }
    }
}
