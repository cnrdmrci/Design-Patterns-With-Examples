using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Abstract
{
    public interface IComputer
    {
        int GetCost();
        void AddCost(int cost);
        ComputerFeature GetComputerFeature();
    }
}
