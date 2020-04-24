using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.FacadeBuilder
{
    public class ComputerBuilderFacade
    {
        protected Computer Computer { get; set; }

        public ComputerBuilderFacade()
        {
            Computer = new Computer();
        }

        public static ComputerBuilderFacade GetInstance() => new ComputerBuilderFacade();
        public Computer Build() => Computer;

        public ComputerSoftwareBuilder Software => new ComputerSoftwareBuilder(Computer);
        public ComputerHardwareBuilder Hardware => new ComputerHardwareBuilder(Computer);
    }
}
