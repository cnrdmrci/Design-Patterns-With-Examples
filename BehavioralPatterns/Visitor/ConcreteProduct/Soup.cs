using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Visitor.AbstractProduct;
using DesignPatterns.BehavioralPatterns.Visitor.AbstractVisitor;

namespace DesignPatterns.BehavioralPatterns.Visitor.ConcreteProduct
{
    public class Soup : IFood
    {
        public decimal Price { get; set; }

        public Soup(decimal price)
        {
            Price = price;
        }
        public void Accept(IFoodVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
