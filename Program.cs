using System;
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
