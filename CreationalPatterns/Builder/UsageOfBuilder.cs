using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Builder.FacadeBuilder;

namespace DesignPatterns.CreationalPatterns.Builder
{
    public class UsageOfBuilder
    {
        public static void Run()
        {
            Console.WriteLine("Facade Builder");

            Computer computer = ComputerBuilderFacade
                .GetInstance()
                    .Software
                        .SelectOperatingSystem("Windows")
                    .Hardware
                        .AddCpu("i7")
                        .AddRam("16")
                        .AddSsd("256gb")
                        .AddHdd("1tb")
                    .Build();

            Console.WriteLine(computer.ToString());

            //-----------------------------------------------------------
        }
    }
}
