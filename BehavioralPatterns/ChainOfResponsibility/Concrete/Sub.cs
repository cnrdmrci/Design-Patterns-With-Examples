using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Abstract;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Product;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Concrete
{
    public class Sub : OperationHandler
    {
        public override Operation Handle(Operation operation)
        {
            if (operation.OperationType == OperationType.Sub)
            {
                operation.Result = operation.FirstNumber - operation.SecondNumber;
                return operation;
            }

            return base.Handle(operation);
        }
    }
}
