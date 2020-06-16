using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Visitor.AbstractVisitor;

namespace DesignPatterns.BehavioralPatterns.Visitor.AbstractProduct
{
    public interface IFood
    {
        decimal Price { get; set; }
        void Accept(IFoodVisitor visitor);
    }
}
