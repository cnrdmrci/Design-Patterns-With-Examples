using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.Common;
using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Decorate.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Decorate.Concrete
{
    public class Ssd : ComputerDecorator
    {
        public Ssd(IComputer computer) : base(computer)
        {
            Computer.GetComputerFeature().Ssd += 1;
            Computer.AddCost(800);
        }
    }
}
