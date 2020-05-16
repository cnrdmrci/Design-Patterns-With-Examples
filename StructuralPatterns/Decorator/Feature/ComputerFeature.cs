using System;

namespace DesignPatterns.StructuralPatterns.Decorator.Feature
{
    public enum ComputerType
    {
        Laptop,
        DesktopPc
    }
    public class ComputerFeature
    {
        public ComputerType ComputerType { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public int Hdd { get; set; }
        public int Ssd { get; set; }

        public override string ToString()
        {
            return ($@" 
        ------------------------------------
        Computer Features:
        Computer Type : {ComputerType} 
        Cpu : {Cpu}
        Ram : {Ram}
        Hdd : {Hdd}
        Ssd : {Ssd}
        -----------------------------------"
                );
        }
    }
}
