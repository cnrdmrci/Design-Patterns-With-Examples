using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Concrete
{
    public class Laptop : IComputer
    {
        private int _cost;
        private readonly ComputerFeature _computerFeature;
        public Laptop()
        {
            _cost = 4000;
            _computerFeature = new ComputerFeature()
            {
                ComputerType = ComputerType.Laptop,
                Cpu = "2.20Ghz",
                Hdd = 1,
                Ssd = 1,
                Ram = 4
            };
        }

        public int GetCost() => _cost;

        public void AddCost(int cost)
        {
            _cost += cost;
        }

        public ComputerFeature GetComputerFeature() => _computerFeature;
    }
}
