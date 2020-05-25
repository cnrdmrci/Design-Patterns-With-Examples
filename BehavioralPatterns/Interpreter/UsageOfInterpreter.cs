using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.Interpreter.Parser;
using DesignPatterns.BehavioralPatterns.Interpreter.Product;

namespace DesignPatterns.BehavioralPatterns.Interpreter
{
    public class UsageOfInterpreter
    {
        public static void Run()
        {
            Context context = new Context
            {
                Input = "10 44 23 19 - - +"
            };

            ExpressionParser parser = new ExpressionParser(context);
            context = parser.GetResult();

            Console.WriteLine("Input: " + context.Input);
            Console.WriteLine("Output: " + context.Output);
        }
    }
}
