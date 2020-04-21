using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    public class EnglishNewspaper : INewspaperProduct
    {
        public string GetDetails()
        {
            return "English Newspaper";
        }
    }
}
