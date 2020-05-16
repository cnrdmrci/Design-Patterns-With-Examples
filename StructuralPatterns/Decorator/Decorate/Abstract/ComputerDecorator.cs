using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Decorate.Abstract
{
    public abstract class ComputerDecorator : IComputer
    {
        protected readonly IComputer Computer;

        protected ComputerDecorator(IComputer computer)
        {
            Computer = computer;
        }
        public int GetCost() => Computer.GetCost();

        public void AddCost(int cost) => Computer.AddCost(cost);

        public ComputerFeature GetComputerFeature() => Computer.GetComputerFeature();
    }
}
