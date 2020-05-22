using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Abstract;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Concrete;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Product;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public class UsageOfChainOfResponsibility
    {
        public static void Run()
        {
            Add add = new Add();
            Sub sub = new Sub();
            Div div = new Div();
            Mul mul = new Mul();

            add.SetNext(sub).SetNext(div).SetNext(mul);

            Operation addOperation = new Operation { FirstNumber = 10, SecondNumber = 5, OperationType = OperationType.Mul };
            Operation addOperationResult = add.Handle(addOperation);
            Console.WriteLine(addOperationResult);


            Operation noneOperation = new Operation {FirstNumber = 10, SecondNumber = 5, OperationType = OperationType.None};
            Operation noneOperationResult = add.Handle(noneOperation);
            Console.WriteLine(noneOperationResult);

        }
    }
}
