using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.FacadeBuilder
{
    public class ComputerSoftwareBuilder : ComputerBuilderFacade
    {
        public ComputerSoftwareBuilder(Computer computer)
        {
            Computer = computer;
        }

        public ComputerSoftwareBuilder SelectOperatingSystem(string os)
        {
            Computer.OperatingSystem = os;
            return this;
        }
    }
}
