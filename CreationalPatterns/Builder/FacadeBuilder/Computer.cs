using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.FacadeBuilder
{
    public class Computer
    {
        public string OperatingSystem { get; set; }

        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Ssd { get; set; }
        public string Hdd { get; set; }

        public override string ToString()
        {
            return $@"  
                Computer info;
                    Operating System : {OperatingSystem},
                    Cpu : {Cpu},
                    Ram : {Ram},
                    Ssd : {Ssd},
                    Hdd : {Hdd}";
        }
    }
}
