using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.NormalBuilder
{
    public class ComputerBuilder
    {
        private readonly ComputerForNormal _computer;

        public ComputerBuilder()
        {
            _computer = new ComputerForNormal();
        }

        public static ComputerBuilder GetInstance() => new ComputerBuilder();

        public ComputerForNormal Build()
        {
            return _computer;
        }

        public ComputerBuilder SelectOperatingSystem(string os)
        {
            _computer.OperatingSystem = os;
            return this;
        }

        public ComputerBuilder AddCpu(string cpu)
        {
            _computer.Cpu = cpu;
            return this;
        }
        public ComputerBuilder AddRam(string ram)
        {
            _computer.Ram = ram;
            return this;
        }
        public ComputerBuilder AddSsd(string ssd)
        {
            _computer.Ssd = ssd;
            return this;
        }
        public ComputerBuilder AddHdd(string hdd)
        {
            _computer.Hdd = hdd;
            return this;
        }
    }
}
