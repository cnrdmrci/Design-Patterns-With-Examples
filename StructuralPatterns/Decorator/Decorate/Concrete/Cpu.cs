using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.Common;
using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Decorate.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Decorate.Concrete
{
    public class Cpu : ComputerDecorator
    {
        public Cpu(IComputer computer) : base(computer)
        {
            Computer.GetComputerFeature().Cpu = "3.20Ghz";
            Computer.AddCost(1200);
        }
    }
}
