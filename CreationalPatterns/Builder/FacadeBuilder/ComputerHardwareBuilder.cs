using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.FacadeBuilder
{
    public class ComputerHardwareBuilder : ComputerBuilderFacade
    {
        public ComputerHardwareBuilder(Computer computer)
        {
            Computer = computer;
        }

        public ComputerHardwareBuilder AddCpu(string cpu)
        {
            Computer.Cpu = cpu;
            return this;
        }
        public ComputerHardwareBuilder AddRam(string ram)
        {
            Computer.Ram = ram;
            return this;
        }
        public ComputerHardwareBuilder AddSsd(string ssd)
        {
            Computer.Ssd = ssd;
            return this;
        }
        public ComputerHardwareBuilder AddHdd(string hdd)
        {
            Computer.Hdd = hdd;
            return this;
        }
    }
}
