using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.AbstractFactory.AbstractProduct;

namespace DesignPatterns.CreationalPatterns.AbstractFactory.ConcreteFactories
{
    public class EnglishBook : IBookProduct
    {
        public string GetDetails()
        {
            return "English Book";
        }
    }
}
