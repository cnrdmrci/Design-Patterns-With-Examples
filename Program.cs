using System;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started.");

            creationalPatterns();
            behavioralPatterns();
            structuralPatterns();

            Console.WriteLine("Program finished.");
        }

        static void creationalPatterns()
        {
            UsageOfFactoryMethod.Run();
            UsageOfAbstractFactory.Run();
            UsageOfBuilder.Run();
            UsageOfSingleton.Run();
        }

        static void behavioralPatterns()
        {

        }
        
        static void structuralPatterns()
        {

        }
    }
}
