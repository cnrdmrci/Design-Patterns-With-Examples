using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.StructuralPatterns.Decorator.Abstract;
using DesignPatterns.StructuralPatterns.Decorator.Concrete;
using DesignPatterns.StructuralPatterns.Decorator.Decorate.Concrete;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    public class UsageOfDecorator
    {
        public static void Run()
        {
            IComputer laptop = new Laptop();
            IComputer laptopWithRam = new Ram(laptop);
            IComputer laptopWithRamWithCpu = new Cpu(laptopWithRam);
            IComputer laptopWithRamWithCpuWithSsd = new Ssd(laptopWithRamWithCpu);
            Console.WriteLine(laptopWithRamWithCpuWithSsd.GetComputerFeature().ToString());
            Console.WriteLine("\tLaptop total cost: " + laptopWithRamWithCpuWithSsd.GetCost());
            Console.WriteLine("\t------------------------------------");
            Console.WriteLine("\t------------------------------------");

            IComputer desktopPc = new DesktopPc();
            IComputer desktopPcWithRam = new Ram(desktopPc);
            IComputer desktopPcWithRamWithSsd = new Ssd(desktopPcWithRam);
            IComputer desktopPcWithRamWithSsdWithHdd = new Hdd(desktopPcWithRamWithSsd);
            Console.WriteLine(desktopPcWithRamWithSsdWithHdd.GetComputerFeature().ToString());
            Console.WriteLine("\tDesktop Pc total cost: " +  desktopPcWithRamWithSsdWithHdd.GetCost());
            Console.WriteLine("\t------------------------------------");
            Console.WriteLine("\t------------------------------------");
        }
    }
}
