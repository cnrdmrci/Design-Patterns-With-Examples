using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Feature;

namespace DesignPatterns.StructuralPatterns.Decorator.Concrete
{
    public class DesktopPc : IComputer
    {
        private int _cost;
        private readonly ComputerFeature _computerFeature;

        public DesktopPc()
        {
            _cost = 3500;
            _computerFeature = new ComputerFeature()
            {
                ComputerType = ComputerType.DesktopPc,
                Cpu = "2.80Ghz",
                Hdd = 1,
                Ssd = 0,
                Ram = 8
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
