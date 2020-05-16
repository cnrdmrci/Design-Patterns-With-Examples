using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.Common;
using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Decorate.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Decorate.Concrete
{
    public class Ram : ComputerDecorator
    {
        public Ram(IComputer computer) : base(computer)
        {
            Computer.GetComputerFeature().Ram += 8;
            Computer.AddCost(300);
        }
    }
}
