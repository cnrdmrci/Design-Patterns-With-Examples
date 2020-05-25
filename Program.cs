using System;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.BehavioralPatterns.Command;
using DesignPatterns.BehavioralPatterns.Interpreter;
using DesignPatterns.CreationalPatterns.AbstractFactory;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.FactoryMethod;
using DesignPatterns.CreationalPatterns.ObjectPool;
using DesignPatterns.CreationalPatterns.Prototype;
using DesignPatterns.CreationalPatterns.Singleton;
using DesignPatterns.StructuralPatterns.Adapter;
using DesignPatterns.StructuralPatterns.Bridge;
using DesignPatterns.StructuralPatterns.Composite;
using DesignPatterns.StructuralPatterns.Decorator;
using DesignPatterns.StructuralPatterns.Facade;
using DesignPatterns.StructuralPatterns.FlyWeight;
using DesignPatterns.StructuralPatterns.Proxy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program started.");

            //creationalPatterns();
            //structuralPatterns();
            behavioralPatterns();

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
            //UsageOfChainOfResponsibility.Run();
            //UsageOfCommand.Run();
            UsageOfInterpreter.Run();
        }
        
        static void structuralPatterns()
        {
            UsageOfAdapter.Run();
            UsageOfBridge.Run();
            UsageOfComposite.Run();
            UsageOfDecorator.Run();
            UsageOfProxy.Run();
            UsageOfFlyWeight.Run();
            UsageOfFacade.Run();
        }
    }
}
