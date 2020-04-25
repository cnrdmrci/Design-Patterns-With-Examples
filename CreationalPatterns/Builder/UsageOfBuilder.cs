using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.CreationalPatterns.Builder.FacadeBuilder;
using DesignPatterns.CreationalPatterns.Builder.NormalBuilder;
using DesignPatterns.CreationalPatterns.Builder.SeperatedBuilder;
using Computer = DesignPatterns.CreationalPatterns.Builder.FacadeBuilder.Computer;

namespace DesignPatterns.CreationalPatterns.Builder
{
    public class UsageOfBuilder
    {
        public static void Run()
        {
            Console.WriteLine("Normal Builder");

            ComputerForNormal computerWithNormal = ComputerBuilder
                .GetInstance()
                    .SelectOperatingSystem("Windows")
                    .AddCpu("i7")
                    .AddRam("16")
                    .AddSsd("256gb")
                    .AddHdd("1tb")
                .Build();

            Console.WriteLine(computerWithNormal.ToString());

            //-----------------------------------------------------------

            Console.WriteLine("Seperate Builder");

            MealDirector mealDirector = new MealDirector(new AdultMealBuilder());
            Meal meal = mealDirector.GetMealMenu();

            Console.WriteLine(meal.ToString());

            //-----------------------------------------------------------

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
