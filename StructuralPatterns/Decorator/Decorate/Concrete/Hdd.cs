using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Prototype.Common;
using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Decorate.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Decorate.Concrete
{
    public class Hdd : ComputerDecorator
    {
        public Hdd(IComputer computer) : base(computer)
        {
            Computer.GetComputerFeature().Hdd += 1;
            Computer.AddCost(500);
        }

    }
}
