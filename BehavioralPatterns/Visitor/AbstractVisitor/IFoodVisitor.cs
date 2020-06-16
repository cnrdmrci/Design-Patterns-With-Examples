using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Visitor.ConcreteProduct;

namespace DesignPatterns.BehavioralPatterns.Visitor.AbstractVisitor
{
    public interface IFoodVisitor
    {
        void Visit(Pizza pizza);
        void Visit(Rice rice);
        void Visit(Sandwich sandwich);
        void Visit(Soup soup);
    }
}
