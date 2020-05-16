using System;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.ObjectPool;
using DesignPatterns.CreationalPatterns.Prototype;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Bridge;
using DesignPatterns.StructuralPatterns.Composite;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started.");

            //creationalPatterns();
            behavioralPatterns();
            structuralPatterns();

            Console.WriteLine("Program finished.");
        }

        static void creationalPatterns()
        {
            UsageOfFactoryMethod.Run();
            UsageOfAbstractFactory.Run();
            UsageOfBuilder.Run();
            UsageOfPrototype.Run();
            UsageOfSingleton.Run();
            UsageOfObjectPool.Run();
        }

        static void behavioralPatterns()
        {

        }
        
        static void structuralPatterns()
        {
            //UsageOfAdapter.Run();
            //UsageOfBridge.Run();
            UsageOfComposite.Run();
        }
    }
}
