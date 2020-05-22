using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Product;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility.Abstract
{
    public enum OperationType
    {
        Add,
        Sub,
        Mul,
        Div,
        None
    }
    public abstract class OperationHandler : IHandler
    {
        protected IHandler NextHandler;
        public IHandler SetNext(IHandler handler)
        {
            NextHandler = handler;
            return handler;
        }

        public virtual Operation Handle(Operation operation)
        {
            return NextHandler?.Handle(operation);
        }
    }
}
